using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroNet.Classes
{
    public class Logger
    {
        private string _log;

        public Logger()
        {
            _log = string.Empty;
        }

        public void writeLog(string input)
        {
            lock (_log)
                _log += "[" + DateTime.Now.ToString() + "] " + input + Environment.NewLine;
        }

        public string Log
        {
            get
            {
                return _log;
            }
        }
    }
}
