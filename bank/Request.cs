using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.Show();
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            tbNumber.TextChanged -= tbNumber_TextChanged;

            var textWithoutComma = tbNumber.Text.Replace(".", string.Empty);
            if (decimal.TryParse(textWithoutComma, out decimal amount))
            {
                tbNumber.Text = string.Format(CultureInfo.CreateSpecificCulture("id-ID"), "{0:N0}", amount);
            }
            else
            {
                tbNumber.Text = string.Empty;
            }

            tbNumber.SelectionStart = tbNumber.Text.Length;

            tbNumber.TextChanged += tbNumber_TextChanged;
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction_Details form = new Transaction_Details("Request");
            form.Show();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.BackHover;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.Back;
        }

        private void btnRequest_MouseHover(object sender, EventArgs e)
        {
            btnRequest.Image = Properties.Resources.RequestHover;
        }

        private void btnRequest_MouseLeave(object sender, EventArgs e)
        {
            btnRequest.Image = Properties.Resources.bRequest;
        }
    }
}
