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
    public partial class RegistryEditorDialog : Form
    {
        Connection _client;

        public RegistryEditorDialog(Connection client)
        {
            InitializeComponent();

            _client = client;
        }

        private void RegistryEditorDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
