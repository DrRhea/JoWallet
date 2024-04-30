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
    public partial class Pulsa : Form
    {
        bool payExpand = false;

        public Pulsa()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            timerPay.Tick += new EventHandler(timerPay_Tick);
            lblBackPay.Click += new EventHandler(lblBackPay_Click);
        }

        private void Pulsa_Load(object sender, EventArgs e)
        {
            HoverLeaverButtons();
        }

        private void lblBackPay_Click(object sender, EventArgs e)
        {
            payExpand = false;
            timerPay.Start();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pin form = new Pin("Pulsa");
            form.Show();
        }

        private void timerPay_Tick(object sender, EventArgs e)
        {
            int step = 470;

            if (payExpand)
            {
                payment.Height -= step;
                if (payment.Height <= payment.MinimumSize.Height)
                {
                    payment.Height = payment.MinimumSize.Height;
                    payExpand = false;
                    timerPay.Stop();                 
                }
            }
            else
            {
                payment.Height += step;
                if (payment.Height >= payment.MaximumSize.Height)
                {
                    payment.Height = payment.MaximumSize.Height;
                    payExpand = true; 
                    timerPay.Stop();
                    ConfigureUIForPaymentClose();
                }
            }

        }

        private void ConfigureUIForPayment(string jumlahPulsa, string harga)
        {
            lblBerubahPulsa.Text = $"Pulsa {jumlahPulsa} " + tbNumber.Text;
            lblHarga.Text = harga;
            btnPay.Text = $"PAY {harga}";
            lblSaldoPay.Text = "Rp.99.200 (Top Up & Pay)";

            btnBack.Enabled = false;
            tbNumber.Enabled = false;

            payExpand = true;
            timerPay.Start();
        }

        private void ConfigureUIForPaymentClose()
        {
            btnBack.Enabled = true;
            tbNumber.Enabled = true;
        }


        private void btn1RB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("1.000", "Rp1.500");
        }

        private void btn3RB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("3.000", "Rp3.500");
        }

        private void btn5RB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("5.000", "Rp5.700");
        }

        private void btn8RB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("8.000", "Rp8.600");
        }

        private void btn10RB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("10.000", "Rp10.500");
        }

        private void btn15RB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("15.000", "Rp15.200");
        }

        private void btn25RB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("25.000", "Rp24.950");
        }

        private void btn100RB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("100.000", "Rp99.200");
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.Show();
        }

        private void SetButtonHoverEffects(PictureBox btn, Image hoverImage, Image normalImage)
        {
            btn.MouseHover += (sender, e) => {
                btn.Image = hoverImage;
            };

            btn.MouseLeave += (sender, e) => {
                btn.Image = normalImage;
            };
        }

        private void HoverLeaverButtons()
        {
            SetButtonHoverEffects(btn1RB, Properties.Resources.aa, Properties.Resources.a);
            SetButtonHoverEffects(btn3RB, Properties.Resources.cc, Properties.Resources.c);
            SetButtonHoverEffects(btn5RB, Properties.Resources.dd, Properties.Resources.d);
            SetButtonHoverEffects(btn8RB, Properties.Resources.ee, Properties.Resources.e);
            SetButtonHoverEffects(btn10RB, Properties.Resources.ff, Properties.Resources.f);
            SetButtonHoverEffects(btn15RB, Properties.Resources.gg, Properties.Resources.g);
            SetButtonHoverEffects(btn25RB, Properties.Resources.hh, Properties.Resources.h);
            SetButtonHoverEffects(btn100RB, Properties.Resources.ii, Properties.Resources.i);

        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.Black;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.White;
        }
    }
}
