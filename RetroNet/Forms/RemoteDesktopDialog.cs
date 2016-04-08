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
    public partial class RemoteDesktopDialog : Form
    {
        private Connection _client;

        public RemoteDesktopDialog(Connection client)
        {
            InitializeComponent();

            _client = client;
        }

        private void RemoteDesktopDialog_Load(object sender, EventArgs e)
        {
            _client.send(new Packet(Command.StartRemoteDesktop).toArray());
        }

        private void RemoteDesktopDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.send(new Packet(Command.StopRemoteDesktop).toArray());
        }

        private void qualityTrackBar_Scroll(object sender, EventArgs e)
        {
            Packet toSend = new Packet(Command.RemoteDesktopQuality);

            toSend.addData((qualityTrackBar.Value * 2).ToString());
            _client.send(toSend.toArray());
        }

        private void RemoteDesktopDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyboardCheckBox.Checked)
            {
                Packet toSend = new Packet(Command.RemoteDesktopKeyDown);

                toSend.addData(((int)e.KeyCode).ToString());
                _client.send(toSend.toArray());
            }
        }

        private void RemoteDesktopDialog_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyboardCheckBox.Checked)
            {
                Packet toSend = new Packet(Command.RemoteDesktopKeyUp);

                toSend.addData(((int)e.KeyCode).ToString());
                _client.send(toSend.toArray());
            }
        }

        private void desktopPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouseCheckBox.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Packet toSend = new Packet(Command.RemoteDesktopLDown);

                    toSend.addData(Math.Round((double)e.X / desktopPictureBox.Width, 2).ToString());
                    toSend.addData(Math.Round((double)e.Y / desktopPictureBox.Height, 2).ToString());

                    _client.send(toSend.toArray());
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Packet toSend = new Packet(Command.RemoteDesktopRDown);

                    toSend.addData(Math.Round((double)e.X / desktopPictureBox.Width, 2).ToString());
                    toSend.addData(Math.Round((double)e.Y / desktopPictureBox.Height, 2).ToString());

                    _client.send(toSend.toArray());
                }
            }
        }

        private void desktopPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseCheckBox.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Packet toSend = new Packet(Command.RemoteDesktopLUp);

                    toSend.addData(Math.Round((double)e.X / desktopPictureBox.Width, 2).ToString());
                    toSend.addData(Math.Round((double)e.Y / desktopPictureBox.Height, 2).ToString());

                    _client.send(toSend.toArray());
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Packet toSend = new Packet(Command.RemoteDesktopRUp);

                    toSend.addData(Math.Round((double)e.X / desktopPictureBox.Width, 2).ToString());
                    toSend.addData(Math.Round((double)e.Y / desktopPictureBox.Height, 2).ToString());

                    _client.send(toSend.toArray());
                }
            }
        }

        public void updateImage(Image img)
        {
            lock (desktopPictureBox)
            {
                if (img != null)
                    desktopPictureBox.Image = img;
            }
        }
    }
}
