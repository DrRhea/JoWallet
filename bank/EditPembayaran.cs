using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bank
{
    public partial class EditPembayaran : Form
    {
        List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

        public EditPembayaran()
        {
            InitializeComponent();
            LoadPaymentMethods();
            BindPaymentMethodsToGridView();
        }

        private void LoadPaymentMethods()
        {
            //
        }

        private void BindPaymentMethodsToGridView()
        {
            dataGridTopUp.DataSource = paymentMethods;
        }

        private void DisplayPaymentMethods()
        {
            dataGridTopUp.DataSource = null; //
            dataGridTopUp.DataSource = paymentMethods;
        }

        private void EditPembayaran_Load(object sender, EventArgs e)
        {
            DisplayPaymentMethods();
            HoverLeaverButtons();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin form = new Admin();
            form.Show();
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
            SetButtonHoverEffects(btnBack, Properties.Resources.BackHover, Properties.Resources.Back);
            SetButtonHoverEffects(btnAdd, Properties.Resources.ButtonAddHover, Properties.Resources.ButtonAdd);
            SetButtonHoverEffects(btnDelete, Properties.Resources.ButtonDeleteHover, Properties.Resources.ButtonDelete);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Name and ID Number cannot be empty.");
                return;
            }

            var newMethod = new PaymentMethod
            {
                Name = tbName.Text.Trim(),
                AccountId = tbID.Text.Trim()
            };
            paymentMethods.Add(newMethod);

            BindPaymentMethodsToGridView();

            tbName.Clear();
            tbID.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedMethod = dataGridTopUp.CurrentRow.DataBoundItem as PaymentMethod;
            if (selectedMethod != null)
            {
                paymentMethods.Remove(selectedMethod);

                DisplayPaymentMethods();
            }
        }
    }
}
