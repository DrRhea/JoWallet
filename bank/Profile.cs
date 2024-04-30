using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bank
{
    public partial class Profile : Form
    {
        private string actualAccountId = "1234567890";

        public Profile()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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
            SetButtonHoverEffects(btnEdit, Properties.Resources.EditHover, Properties.Resources.EditWhite);
            SetButtonHoverEffects(btnLogout, Properties.Resources.Sign_in___btn, Properties.Resources.Sign_in___btn50_);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeProfile form = new ChangeProfile();
            form.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            btnNotifON.Visible = false;
            btnShow.Visible = false;
            HoverLeaverButtons();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnShow.Visible = false;
            lblVirtualID.Text = actualAccountId;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            lblVirtualID.Text = new string('●', actualAccountId.Length);
        }

        private void btnNotifOFF_Click(object sender, EventArgs e)
        {
            btnNotifON.Visible = true;
            btnNotifOFF.Visible = false;
        }

        private void btnNotifON_Click(object sender, EventArgs e)
        {
            btnNotifOFF.Visible = true;
            btnNotifON.Visible = false;
        }
    }
}
