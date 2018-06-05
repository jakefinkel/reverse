using System;
using System.Windows.Forms;
using System.Linq;

namespace reverse
{
    public partial class Reverse : Form
    {
        public Reverse()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Processing...";
            if (String.IsNullOrWhiteSpace(txtPlays.Text))
            {
                lblStatus.Text = "Please paste in valid input";
                return;
            }
            var lines = txtPlays.Text.Split('\n');
            txtPlays.Text = lines.Aggregate((line, next) =>next + "\r\n" + line);
            txtPlays.SelectAll();
            txtPlays.Copy();
            lblStatus.Text = "Sorted!";
        }
    }
}