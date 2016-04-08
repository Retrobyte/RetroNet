using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RetroNet.Classes
{
    public class Upload
    {
        private Connection _client;
        private byte[] _file;
        private int _position;
        private AutoResetEvent _waiter;

        public Upload(Connection client, string path)
        {
            _client = client;
            _file = File.ReadAllBytes(path);
            _waiter = new AutoResetEvent(false);
        }

        public void beginSend(int id, string uploadPath)
        {
            Thread t = new Thread(() =>
            {
                Packet toSend = new Packet(Command.UploadFileBegin);

                toSend.addData(id.ToString());
                toSend.addData(uploadPath);

                _client.send(toSend.toArray());
                _client.updateUploadProgress(id, 0);

                byte[] data = readChunk();
                _waiter.WaitOne();

                while (data != null)
                {
                    Packet dataSend = new Packet(Command.UploadFilePart);

                    dataSend.addData(id.ToString());
                    dataSend.addData(data);

                    _client.send(dataSend.toArray());
                    _client.updateUploadProgress(id, getProgress());

                    data = readChunk();
                    _waiter.WaitOne();
                }

                Packet endSend = new Packet(Command.UploadFileEnd);
                endSend.addData(id.ToString());

                _client.send(endSend.toArray());
                _client.updateUploadProgress(id, 100);
            });

            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;
            t.Start();
        }

        public void release()
        {
            _waiter.Set();
        }

        private byte[] readChunk()
        {
            if (_position < _file.Length - 1)
            {
                byte[] ret;
                int diff = _file.Length - _position;

                if (diff > 1024)
                    ret = new byte[1024];
                else
                    ret = new byte[diff];

                Buffer.BlockCopy(_file, _position, ret, 0, ret.Length);
                _position += ret.Length;

                return ret;
            }

            return null;
        }

        private double getProgress()
        {
            return Math.Round(((double)_position) / _file.Length, 2);
        }
    }
}
