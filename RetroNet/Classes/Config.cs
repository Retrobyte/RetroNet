using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroNet.Classes
{
    public class Config : IniFile
    {
        private List<int> _ports;

        public Config(string filename) : base(filename)
        {
            _ports = new List<int>();

            load();
        }

        public bool addPort(int portNum)
        {
            if (_ports.Contains(portNum))
                return false;

            _ports.Add(portNum);

            return true;
        }

        public bool removePort(int portNum)
        {
            if (!_ports.Contains(portNum))
                return false;

            _ports.Remove(portNum);

            return true;
        }

        public void load()
        {
            if (File.Exists(_filename))
            {
                string port = readValue("Settings", "Ports", _filename);

                foreach (string s in port.Split(','))
                    _ports.Add(Convert.ToInt32(s));

                ShowMessageOnConnection = Convert.ToBoolean(readValue("Settings", "Message", _filename));
                PlaySoundOnConnection = Convert.ToBoolean(readValue("Settings", "Sound", _filename));
            }
        }

        public void save()
        {
            string port = string.Empty;

            foreach (int i in _ports)
                port += i + ",";

            writeValue("Settings", "Ports", port.Length > 0 ? port.Substring(0, port.Length - 1) : string.Empty, _filename);
            writeValue("Settings", "Message", ShowMessageOnConnection.ToString(), _filename);
            writeValue("Settings", "Sound", PlaySoundOnConnection.ToString(), _filename);
        }

        public int[] Ports
        {
            get
            {
                return _ports.ToArray();
            }
        }

        public bool ShowMessageOnConnection { get; set; }

        public bool PlaySoundOnConnection { get; set; }
    }
}
