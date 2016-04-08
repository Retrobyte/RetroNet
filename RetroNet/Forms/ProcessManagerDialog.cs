using RetroNet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroNet.Forms
{
    public partial class ProcessManagerDialog : Form
    {
        Connection _client;
        List<string> _suspended;

        public ProcessManagerDialog(Connection client)
        {
            InitializeComponent();

            _client = client;
            _suspended = new List<string>();
        }

        private void ProcessManagerDialog_Load(object sender, EventArgs e)
        {
            _client.send((new Packet(Command.GetProcessList).toArray()));
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _client.send((new Packet(Command.GetProcessList).toArray()));
        }

        private void suspendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packet toSend = new Packet(Command.SuspendProcess);

            foreach (ListViewItem l in processListView.SelectedItems)
            {
                if (l.BackColor != Color.Yellow)
                {
                    toSend.addData(l.SubItems[1].Text);
                    l.BackColor = Color.Yellow;

                    _suspended.Add(l.SubItems[1].Text);
                }
            }

            _client.send(toSend.toArray());
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packet toSend = new Packet(Command.ResumeProcess);

            foreach (ListViewItem l in processListView.SelectedItems)
            {
                if (l.BackColor == Color.Yellow)
                {
                    toSend.addData(l.SubItems[1].Text);
                    l.BackColor = Color.White;

                    _suspended.Remove(l.SubItems[1].Text);
                }
            }

            _client.send(toSend.toArray());
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packet toSend = new Packet(Command.KillProcess);

            foreach (ListViewItem l in processListView.SelectedItems)
            {
                toSend.addData(l.SubItems[1].Text);
                l.Remove();
            }

            _client.send(toSend.toArray());
        }

        public void updateList(Packet p)
        {
            processListView.Items.Clear();

            for (int i = 0; i < p.Data.Length; i += 2)
            {
                string name = Encoding.Unicode.GetString(p.Data[i]);
                string id = Encoding.Unicode.GetString(p.Data[i + 1]);

                ListViewItem l = new ListViewItem(new string[] { name, id });

                if (_suspended.Contains(id))
                    l.BackColor = Color.Yellow;

                processListView.Items.Add(l);
            }
        }
    }
}

