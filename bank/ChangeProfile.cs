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
    public partial class ChangeProfile : Form
    {
        public ChangeProfile()
        {
            InitializeComponent();
            tbName.ReadOnly = true;
            tbNumber.ReadOnly = true;
            tbPin.ReadOnly = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile form = new Profile();
            form.Show();
        }

        private void ChangeProfile_Load(object sender, EventArgs e)
        {
            btnShow.Visible = false;
            HoverLeaverButtons();
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnShow.Visible = false;
            tbPin.PasswordChar = '\0';
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            tbPin.PasswordChar = '●';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbName.ReadOnly = true;
            tbNumber.ReadOnly = true;
            tbName.BackAlpha = 50;
            tbNumber.BackAlpha = 50;
        }

        private void lblChangePIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot form = new Forgot();
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
            SetButtonHoverEffects(btnBack, Properties.Resources.BackHover, Properties.Resources.Back);
            SetButtonHoverEffects(btnEditName, Properties.Resources.EditHover, Properties.Resources.EditWhite);
            SetButtonHoverEffects(btnEditNumber, Properties.Resources.EditHover, Properties.Resources.EditWhite);
            SetButtonHoverEffects(btnSave, Properties.Resources.ButtonSaveHover, Properties.Resources.ButtonSave);
        }

        private void lblChangePIN_MouseHover(object sender, EventArgs e)
        {
            lblChangePIN.ForeColor = Color.White;
            lblChangePIN.Font = new Font(lblChangePIN.Font, FontStyle.Underline);
        }

        private void lblChangePIN_MouseLeave(object sender, EventArgs e)
        {
            lblChangePIN.ForeColor = Color.Black;
            lblChangePIN.Font = new Font(lblChangePIN.Font, FontStyle.Regular);
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            tbName.ReadOnly = false;
            tbNumber.ReadOnly = true;
            tbName.BackAlpha = 0;
            tbNumber.BackAlpha = 50;
        }

        private void btnEditNumber_Click(object sender, EventArgs e)
        {
            tbNumber.ReadOnly = false;
            tbName.ReadOnly = true;
            tbNumber.BackAlpha = 0;
            tbName.BackAlpha = 50;
        }
    }
}
