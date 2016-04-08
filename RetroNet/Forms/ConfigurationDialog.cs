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
    public partial class ConfigurationDialog : Form
    {
        private Config _con;
        private List<int> _tempAdd;
        private List<int> _tempRemove;

        public ConfigurationDialog(Config c)
        {
            InitializeComponent();

            _con = c;
            _tempAdd = new List<int>();
            _tempRemove = new List<int>();

            foreach (int port in _con.Ports)
                portsListView.Items.Add(new ListViewItem(port.ToString()));

            messageNotificationCheckBox.Checked = _con.ShowMessageOnConnection;
            soundNotificationCheckBox.Checked = _con.PlaySoundOnConnection;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InputDialog id = new InputDialog("Type a port number:", @"^\d+$"))
            {
                if (id.ShowDialog() == DialogResult.OK)
                {
                    int port = Convert.ToInt32(id.Input);

                    if (port < 1 || port > 65535)
                    {
                        MessageBox.Show("Invalid port number entered.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (_con.Ports.Contains(port) && _tempRemove.Contains(port))
                    {
                        _tempRemove.Remove(port);
                    }
                    else if (_con.Ports.Contains(port) || _tempAdd.Contains(port))
                    {
                        MessageBox.Show("Port, " + port.ToString() + ", has already been added.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _tempAdd.Add(port);
                    portsListView.Items.Add(new ListViewItem(port.ToString()));
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in portsListView.SelectedItems)
            {
                int port = Convert.ToInt32(l.Text);

                if (_tempAdd.Contains(port))
                {
                    _tempAdd.Remove(port);
                }
                else if (_con.Ports.Contains(port))
                {
                    _tempRemove.Add(port);
                }

                l.Remove();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (int port in _tempAdd)
                _con.addPort(port);

            foreach (int port in _tempRemove)
                _con.removePort(port);

            _con.ShowMessageOnConnection = messageNotificationCheckBox.Checked;
            _con.PlaySoundOnConnection = soundNotificationCheckBox.Checked;

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
