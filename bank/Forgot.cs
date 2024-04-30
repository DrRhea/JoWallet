using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class Forgot : Form
    {
        public Forgot()
        {
            InitializeComponent();
        }

        private void Forgot_Load(object sender, EventArgs e)
        {
            btnShow.Visible = false;
        }

        private void tbPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPinRetry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            tbPin.PasswordChar = '\0';
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnShow.Visible = false;
            tbPin.PasswordChar = '●';
        }

        private void btnHideRetry_Click(object sender, EventArgs e)
        {
            btnShowRetry.Visible = true;
            btnHideRetry.Visible = false;
            tbPin.PasswordChar = '\0';
        }

        private void btnShowRetry_Click(object sender, EventArgs e)
        {
            btnHideRetry.Visible = true;
            btnShowRetry.Visible = false;
            tbPin.PasswordChar = '●';
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void buttonSet_MouseHover(object sender, EventArgs e)
        {
            buttonSet.Image = Properties.Resources.ButtonSetHover;
        }

        private void buttonSet_MouseLeave(object sender, EventArgs e)
        {
            buttonSet.Image = Properties.Resources.ButtonSet;
        }
    }
}
