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
    public partial class ServiceAdministerDialog : Form
    {
        Connection _client;

        public ServiceAdministerDialog(Connection client)
        {
            InitializeComponent();

            _client = client;
        }

        private void servicesMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = servicesListView.SelectedItems.Count == 0;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
