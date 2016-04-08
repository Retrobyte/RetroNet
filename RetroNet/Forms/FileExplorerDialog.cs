using RetroNet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroNet.Forms
{
    public partial class FileExplorerDialog : Form
    {
        Connection _client;

        public FileExplorerDialog(Connection client)
        {
            InitializeComponent();

            _client = client;
        }

        private void FileExplorerDialog_Load(object sender, EventArgs e)
        {
            _client.send(new Packet(Command.GetRootDrives).toArray());
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(locationTextBox.Text))
                return;

            if (locationTextBox.Text.Length == 3)
            {
                _client.send(new Packet(Command.GetRootDrives).toArray());
            }
            else
            {
                Packet toSend = new Packet(Command.Navigate);
                string path = locationTextBox.Text.Substring(0, locationTextBox.Text.Substring(0, locationTextBox.Text.Length - 1).LastIndexOf(@"\") + 1);

                toSend.addData(path);
                _client.send(toSend.toArray());

                locationTextBox.Text = path;
            }
        }

        private void filesListView_DoubleClick(object sender, EventArgs e)
        {
            if (filesListView.SelectedItems.Count > 0 && filesListView.SelectedItems[0].ImageIndex != 2)
            {
                if (filesListView.SelectedItems[0].ImageIndex == 0)
                    locationTextBox.Text += filesListView.SelectedItems[0].Text;
                else
                    locationTextBox.Text += filesListView.SelectedItems[0].Text + @"\";

                Packet toSend = new Packet(Command.Navigate);

                toSend.addData(locationTextBox.Text);
                _client.send(toSend.toArray());
            }
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filesListView.SelectedItems.Count > 0 && filesListView.SelectedItems[0].ImageIndex == 2)
            {
                Packet toSend = new Packet(Command.ExecuteFile);

                toSend.addData(locationTextBox.Text + filesListView.SelectedItems[0].Text);
                _client.send(toSend.toArray());
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filesListView.SelectedItems.Count > 0)
            {
                if (filesListView.SelectedItems[0].ImageIndex == 1)
                {
                    Packet toSend = new Packet(Command.DeleteFolder);

                    toSend.addData(locationTextBox.Text + filesListView.SelectedItems[0].Text + @"\");
                    _client.send(toSend.toArray());
                }
                else if (filesListView.SelectedItems[0].ImageIndex == 2)
                {
                    Packet toSend = new Packet(Command.DeleteFile);

                    toSend.addData(locationTextBox.Text + filesListView.SelectedItems[0].Text);
                    _client.send(toSend.toArray());
                }

                filesListView.SelectedItems[0].Remove();
            }
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int id;
                    Upload u = new Upload(_client, ofd.FileName);

                    lock (_client.Uploads)
                    {
                        id = _client.Uploads.Count + 1;
                        _client.Uploads.Add(id, u);
                    }

                    u.beginSend(id, locationTextBox.Text + Path.GetFileName(ofd.FileName));
                }
            }
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filesListView.SelectedItems.Count > 0 && filesListView.SelectedItems[0].ImageIndex == 2)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { FileName = filesListView.SelectedItems[0].Text })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        int id;
                        Download d = new Download(_client, sfd.FileName, (long)filesListView.SelectedItems[0].Tag);

                        lock (_client.Downloads)
                        {
                            id = _client.Downloads.Count + 1;
                            _client.Downloads.Add(id, d);
                        }

                        d.beginDownload(id, locationTextBox.Text + filesListView.SelectedItems[0].Text);
                    }
                }
            }
        }

        public void updateRootDrives(Packet p)
        {
            locationTextBox.safeInvoke(() =>
                {
                    locationTextBox.Clear();
                });

            filesListView.safeInvoke(() =>
                {
                    filesListView.Items.Clear();

                    for (int i = 0; i < p.Data.Length; i += 2)
                        filesListView.Items.Add(new ListViewItem(new string[] { Encoding.Unicode.GetString(p.Data[i]), Sizer.convertSize(Encoding.Unicode.GetString(p.Data[i + 1])) }) { ImageIndex = 0 });

                });
        }

        public void updateFiles(Packet p)
        {
            filesListView.safeInvoke(() =>
                {
                    filesListView.Items.Clear();

                    for (int i = 0; i < p.Data.Length; i++)
                    {
                        string s = Encoding.Unicode.GetString(p.Data[i]);

                        if (s.StartsWith("-"))
                        {
                            filesListView.Items.Add(new ListViewItem(new string[] { s.Substring(1) }) { ImageIndex = 1 });
                        }
                        else if (s.StartsWith("_"))
                        {
                            long size = Convert.ToInt64(Encoding.Unicode.GetString(p.Data[i + 1]));
                            filesListView.Items.Add(new ListViewItem(new string[] { s.Substring(1), Sizer.convertSize(size) }) { ImageIndex = 2, Tag = size });
                            i++;
                        }
                    }
                });
        }
    }
}
