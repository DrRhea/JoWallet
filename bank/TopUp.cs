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
using Bunifu.UI.WinForms;

namespace bank
{
    public partial class TopUp : Form
    {
        private List<PaymentMethod> paymentMethods;
        bool payExpand = false;
        bool methodExpand = false;

        public TopUp()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            timerPay.Tick += new EventHandler(timerPay_Tick);
            lblBackPay.Click += new EventHandler(lblBackPay_Click);
            tbNumber.TextChanged += tbNumber_TextChanged;
            InitializePaymentMethods();
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

        private void TopUp_Load(object sender, EventArgs e)
        {
            HoverLeaverButtons();
            UpdatePaymentMethodVisibility();
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
            SetButtonHoverEffects(btn20, Properties.Resources.topup11, Properties.Resources.topup1);
            SetButtonHoverEffects(btn50, Properties.Resources.topup22, Properties.Resources.topup2);
            SetButtonHoverEffects(btn100, Properties.Resources.topup33, Properties.Resources.topup3);
            SetButtonHoverEffects(btn200, Properties.Resources.topup44, Properties.Resources.topup4);
            SetButtonHoverEffects(btn300, Properties.Resources.topup55, Properties.Resources.topup5);
            SetButtonHoverEffects(btn500, Properties.Resources.topup66, Properties.Resources.topup6);
            SetButtonHoverEffects(btnBack, Properties.Resources.BackHover, Properties.Resources.Back);
            SetButtonHoverEffects(btnPay, Properties.Resources.ConfirmHover, Properties.Resources.Confirm);
            SetButtonHoverEffects(btnOK, Properties.Resources.EditHover, Properties.Resources.EditWhite);
            SetButtonHoverEffects(btnOKMethod, Properties.Resources.ButtonOKHover, Properties.Resources.ButtonOK);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("Rp20.000", "Rp20.000");
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("Rp50.000", "Rp50.000");
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("Rp100.000", "Rp100.000");
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("Rp200.000", "Rp200.000");
        }

        private void btn300_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("Rp300.000", "Rp300.000");
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            ConfigureUIForPayment("Rp500.000", "Rp500.000");
        }

        private void timerPay_Tick(object sender, EventArgs e)
        {
            int step = 435;

            if (payExpand)
            {
                payment.Height -= step;
                if (payment.Height <= payment.MinimumSize.Height)
                {
                    payment.Height = payment.MinimumSize.Height;
                    payExpand = false;
                    btnPay.Enabled = false;
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
                    btnPay.Enabled = true;
                    timerPay.Stop();
                    ConfigureUIForPaymentClose();
                }
            }
        }

        private void ConfigureUIForPayment(string jumlah, string harga)
        {
            lblBerubah.Text = $"{jumlah} ";
            lblHarga.Text = harga;

            btnBack.Enabled = false;
            tbNumber.Text = jumlah;
            tbNumber.Enabled = false;

            payExpand = true;
            timerPay.Start();
        }

        private void ConfigureUIForPaymentClose()
        {
            btnBack.Enabled = true;
            tbNumber.Enabled = true;
        }

        private void timerMethod_Tick(object sender, EventArgs e)
        {
            int step = 400;

            if (methodExpand)
            {
                if (hoverMethod.Height + step < hoverMethod.MaximumSize.Height)
                {
                    hoverMethod.Height += step;
                }
                else
                {
                    hoverMethod.Height = hoverMethod.MaximumSize.Height;
                    methodExpand = false;
                    timerMethod.Stop();
                }
            }
            else
            {
                if (hoverMethod.Height - step > hoverMethod.MinimumSize.Height)
                {
                    hoverMethod.Height -= step;
                }
                else
                {
                    hoverMethod.Height = hoverMethod.MinimumSize.Height;
                    methodExpand = true; 
                    timerMethod.Stop();
                    ConfigureUIForPaymentClose();
                }
            }

        }

        private void lblBackPay_Click(object sender, EventArgs e)
        {
            payExpand = false;
            timerPay.Start();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction_Details form = new Transaction_Details("TopUp");
            form.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            methodExpand = true;
            timerMethod.Start();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbNumber.Text != "")
            {
                ConfigureUIForPayment($"Rp{nominal}", $"Rp{nominal}");
            }
        }

        string nominal;
        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            tbNumber.TextChanged -= tbNumber_TextChanged;

            var textWithoutComma = tbNumber.Text.Replace(".", string.Empty);
            if (decimal.TryParse(textWithoutComma, out decimal amount))
            {
                tbNumber.Text = string.Format(CultureInfo.CreateSpecificCulture("id-ID"), "{0:N0}", amount);
                nominal = tbNumber.Text;
            }
            else
            {
                tbNumber.Text = string.Empty;
            }

            tbNumber.SelectionStart = tbNumber.Text.Length;

            tbNumber.TextChanged += tbNumber_TextChanged;
        }

        string method;
        private void btnOKMethod_Click(object sender, EventArgs e)
        {
            lblMethod.Text = "AlfaKidi";
            methodExpand = false;
            timerMethod.Start();
        }

        private void InitializePaymentMethods()
        {
            paymentMethods = new List<PaymentMethod>
            {
                new PaymentMethod
                {
                    Name = "AlfaKidi",
                    AccountId = "xxxxxx",
                    Logo = logoPayment1, 
                    NameLabel = lblPayment1, 
                    RadioButton = rbPayment1, 
                    LinePanel = line1,
                    IsVisible = true 
                },

                new PaymentMethod
                {
                    Name = "Bank Jago",
                    AccountId = "xxxxxx",
                    Logo = logoPayment2,
                    NameLabel = lblPayment2,
                    RadioButton = rbPayment2,
                    LinePanel = line2,
                    IsVisible = false
                },

                new PaymentMethod
                {
                    Name = "IndoJuli",
                    AccountId = "xxxxxx",
                    Logo = logoPayment3,
                    NameLabel = lblPayment3,
                    RadioButton = rbPayment3,
                    LinePanel = line3,
                    IsVisible = false
                },

                new PaymentMethod
                {
                    Name = "Metode 1",
                    AccountId = "xxxxxx",
                    Logo = logoPayment4,
                    NameLabel = lblPayment4,
                    RadioButton = rbPayment4,
                    LinePanel = line4,
                    IsVisible = false
                },

                new PaymentMethod
                {
                    Name = "Metode ",
                    AccountId = "xxxxxx",
                    Logo = logoPayment5,
                    NameLabel = lblPayment5,
                    RadioButton = rbPayment5,
                    LinePanel = line5,
                    IsVisible = false
                },
            };
        }

        private void UpdatePaymentMethodVisibility()
        {
            foreach (var method in paymentMethods)
            {
                method.Logo.Visible = method.IsVisible;
                method.NameLabel.Visible = method.IsVisible;
                method.RadioButton.Visible = method.IsVisible;
                method.LinePanel.Visible = method.IsVisible;

                if (!method.IsVisible)
                {
                    method.NameLabel.Text = "none";
                }
                else
                {
                    method.NameLabel.Text = method.Name;
                }
            }
        }
    }
}
