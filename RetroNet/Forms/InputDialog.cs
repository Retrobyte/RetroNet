using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroNet.Forms
{
    public partial class InputDialog : Form
    {
        private string _validator;

        public InputDialog(string instruction, string validator)
        {
            InitializeComponent();

            Text = instruction;
            _validator = validator;
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OkButton.PerformClick();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputTextBox.Text))
            {
                MessageBox.Show("Input value cannot be left empty.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(_validator) && Regex.Match(inputTextBox.Text, _validator).Length == 0)
            {
                MessageBox.Show("Input value contains invalid characters.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public string Input
        {
            get
            {
                return inputTextBox.Text;
            }
        }
    }
}
