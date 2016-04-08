using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroNet.Classes
{
    public class Packet
    {
        private Command _cmd;
        private List<Byte[]> _data;

        public Packet(Command cmd)
        {
            _cmd = cmd;
            _data = new List<byte[]>();
        }

        public Packet(byte[] data)
        {
            _cmd = (Command)data[0];
            _data = new List<byte[]>();

            int pos = 1;

            while (pos < data.Length)
            {
                int length = BitConverter.ToInt32(data, pos);
                byte[] barray = new byte[length];

                Buffer.BlockCopy(data, pos + 4, barray, 0, length);
                _data.Add(barray);

                pos += 4 + length;
            }
        }

        public void addData(byte[] data)
        {
            _data.Add(data);
        }

        public void addData(string data)
        {
            _data.Add(Encoding.Unicode.GetBytes(data));
        }

        public void addData(Image data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                data.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                _data.Add(ms.ToArray());
            }
        }

        public byte[] toArray()
        {
            MemoryStream ms = new MemoryStream();

            ms.WriteByte((byte)_cmd);

            foreach (byte[] barray in _data)
            {
                ms.Write(BitConverter.GetBytes(barray.Length), 0, 4);
                ms.Write(barray, 0, barray.Length);
            }

            return ms.ToArray();
        }

        public Command Command
        {
            get
            {
                return _cmd;
            }
        }

        public byte[][] Data
        {
            get
            {
                return _data.ToArray();
            }
        }
    }
}
