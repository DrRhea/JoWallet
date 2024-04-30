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
    public partial class Pin : Form
    {
        private readonly string nextAction;

        public Pin(String nextAction)
        {
            this.nextAction = nextAction;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (nextAction)
            {
                case "Pulsa":
                    this.Hide();
                    Transaction_Details form = new Transaction_Details("Pulsa");
                    form.Show();
                    break;
                case "Data":
                    this.Hide();
                    Transaction_Details form1 = new Transaction_Details("PaketData");
                    form1.Show();
                    break;
                case "Send":
                    this.Hide();
                    Transaction_Details form2 = new Transaction_Details("Send");
                    form2.Show();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (nextAction == "Pulsa")
            {
                this.Hide();
                Pulsa form = new Pulsa();
                form.Show();
            }
            else if (nextAction == "Data")
            {
                this.Hide();
                PaketData form = new PaketData();
                form.Show();
            }
            else if (nextAction == "Send")
            {
                this.Hide();
                Send form = new Send();
                form.Show();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnShow.Visible = false;
            tbPin.PasswordChar = '●';
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            tbPin.PasswordChar = '\0';
        }

        private void tbPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Pin_Load(object sender, EventArgs e)
        {
            btnShow.Visible = false;
        }

        private void btnOK_MouseHover(object sender, EventArgs e)
        {
            btnOK.Image = Properties.Resources.ButtonOKHover;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.Image = Properties.Resources.ButtonOK;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.Image = Properties.Resources.CancelHover;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Image = Properties.Resources.ButtonCancel;
        }
    }
}
