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
    public partial class ApplicationHandlerDialog : Form
    {
        Connection _client;

        public ApplicationHandlerDialog(Connection client)
        {
            InitializeComponent();

            _client = client;
        }

        private void ApplicationHandlerDialog_Load(object sender, EventArgs e)
        {
            _client.send(new Packet(Command.GetApplications).toArray());
        }

        private void applicationsMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = applicationsListView.SelectedItems.Count == 0;
        }

        private void uninstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Packet toSend = new Packet(Command.UninstallApplication);

            foreach (ListViewItem l in applicationsListView.SelectedItems)
            {
                toSend.addData(l.Text);
                l.Remove();
            }

            _client.send(toSend.toArray());
        }

        public void updateApplications(Packet p)
        {
            applicationsListView.Items.Clear();

            for (int i = 0; i < p.Data.Length; i += 3)
            {
                string name = Encoding.Unicode.GetString(p.Data[i]);
                bool quiet = Encoding.Unicode.GetString(p.Data[i + 1]) == "1";
                string uninstall = Encoding.Unicode.GetString(p.Data[i + 2]);

                applicationsListView.Items.Add(new ListViewItem(new string[] { name, uninstall, quiet ? "Yes" : "No" }));
            }
        }
    }
}
