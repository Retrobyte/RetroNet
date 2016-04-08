using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroNet.Classes
{
    public static class Sizer
    {
        public static string convertSize(long length)
        {
            int i = 0;
            double temp = (double)length;
            string[] sizes = { " Bytes", " KB", " MB", " GB", " TB", " PB", " EB" };

            while (temp > 1024)
            {
                temp /= 1024;
                i++;
            }

            return Math.Round(temp, 2) + sizes[i];
        }

        public static string convertSize(string length)
        {
            return convertSize(Convert.ToInt64(length));
        }
    }
}
