using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RetroNet.Classes
{
    public class Download
    {
        private Connection _client;
        private FileStream _fs;
        private long _size;

        private AutoResetEvent _waiter;
        public Download(Connection client, string path, long size)
        {
            _client = client;
            _fs = new FileStream(path, FileMode.Create);
            _size = size;
            _waiter = new AutoResetEvent(false);
        }

        public void beginDownload(int id, string downloadPath)
        {
            Thread t = new Thread(() =>
            {
                Packet toSend = new Packet(Command.DownloadFileBegin);

                toSend.addData(id.ToString());
                toSend.addData(downloadPath);

                _client.send(toSend.toArray());
                _client.updateDownloadProgress(id, 0);

                Packet request = new Packet(Command.DownloadFilePart);
                request.addData(id.ToString());

                byte[] reqData = request.toArray();

                while (_fs.Position < _size)
                {
                    _client.send(reqData);
                    _waiter.WaitOne();
                    _client.updateDownloadProgress(id, getProgress());
                }

                endWrite();

                _client.updateDownloadProgress(id, 100);
            });

            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
        }

        public void writeChunk(byte[] data)
        {
            _fs.Write(data, 0, data.Length);
            _waiter.Set();
        }

        private void endWrite()
        {
            _fs.Close();
        }

        private double getProgress()
        {
            return Math.Round(((double)_fs.Position) / _size, 2);
        }
    }
}
