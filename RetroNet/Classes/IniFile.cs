using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RetroNet.Classes
{
    public abstract class IniFile
    {
        protected string _filename;

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(string ApplicationName, string KeyName, string StrValue, string FileName);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string ApplicationName, string KeyName, string DefaultValue, StringBuilder ReturnString, int nSize, string FileName);

        public IniFile(string filename)
        {
            _filename = filename;
        }

        protected string readValue(string sectionName, string keyName, string filename)
        {
            StringBuilder s = new StringBuilder(255);
            GetPrivateProfileString(sectionName, keyName, string.Empty, s, 255, filename);

            string ret = s.ToString().Trim();

            return string.IsNullOrEmpty(ret) ? null : ret;
        }

        protected void writeValue(string sectionName, string keyName, string keyValue, string fileName)
        {
            WritePrivateProfileString(sectionName, keyName, keyValue, fileName);
        }
    }
}
