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
    public partial class InstantMessengerDialog : Form
    {
        Connection _client;

        public InstantMessengerDialog(Connection client)
        {
            InitializeComponent();

            _client = client;
        }

        private void InstantMessengerDialog_Load(object sender, EventArgs e)
        {

        }

        private void sendTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(sendTextBox.Text))
                sendButton.PerformClick();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }
    }
}
