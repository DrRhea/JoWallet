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
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            HoverLeaverButtons();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin form = new Admin();
            form.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
            SetButtonHoverEffects(btnPrint, Properties.Resources.ButtonPrint, Properties.Resources.ButtoPrint);
            SetButtonHoverEffects(btnDelete, Properties.Resources.ButtonDeleteHover, Properties.Resources.ButtonDelete);
        }
    }
}
