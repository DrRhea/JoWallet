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
    public partial class PaketData : Form
    {
        bool payExpand = false;

        public PaketData()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            timerPay.Tick += new EventHandler(timerPay_Tick);
            lblBackPay.Click += new EventHandler(lblBackPay_Click);
        }

        private void PaketData_Load(object sender, EventArgs e)
        {
            HoverLeaverButtons();
        }

        private void btn3GB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("3GB", "Rp3.700");
        }

        private void btn5GB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("5GB", "Rp5.900");
        }

        private void btn10GB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("10GB", "Rp10.500");
        }

        private void btn15GB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("15GB", "Rp15.700");
        }

        private void btn20GB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("20GB", "Rp20.500");
        }

        private void btn25GB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("25GB", "Rp3.700");
        }

        private void btn55GB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("55GB", "Rp54.950");
        }

        private void btn100GB_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("100GB", "Rp99.200");
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
            SetButtonHoverEffects(btn3GB, Properties.Resources._11, Properties.Resources._1);
            SetButtonHoverEffects(btn5GB, Properties.Resources._22, Properties.Resources._2);
            SetButtonHoverEffects(btn10GB, Properties.Resources._33, Properties.Resources._3);
            SetButtonHoverEffects(btn15GB, Properties.Resources._44, Properties.Resources._4);
            SetButtonHoverEffects(btn20GB, Properties.Resources._66, Properties.Resources._6);
            SetButtonHoverEffects(btn25GB, Properties.Resources._77, Properties.Resources._7);
            SetButtonHoverEffects(btn55GB, Properties.Resources._88, Properties.Resources._8);
            SetButtonHoverEffects(btn100GB, Properties.Resources._99, Properties.Resources.Frame_12);
            SetButtonHoverEffects(btnBack, Properties.Resources.BackHover, Properties.Resources.Back);

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

        private void ConfigureUIForPayment(string jumlahPaket, string harga)
        {
            lblBerubahPaket.Text = $"Paket Data {jumlahPaket} " + tbNumber.Text;
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

        private void lblBackPay_Click(object sender, EventArgs e)
        {
            payExpand = false;
            timerPay.Start();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pin form = new Pin("Data");
            form.Show();
        }
    }
}
