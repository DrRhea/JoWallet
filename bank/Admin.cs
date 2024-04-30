using System;
using System.Configuration;
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
    public partial class Admin : Form
    {
        bool methodExpand = false;

        public Admin()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 60000;
            timer.Tick += (s, args) => UpdateDateTimeAndGreeting();
            timer.Start();
            UpdateDateTimeAndGreeting();
            HoverLeaverButtons();
        }

        private void UpdateDateTimeAndGreeting()
        {
            DateTime now = DateTime.Now;

            string formattedDate = now.ToString("ddd, dd MMMM");
            labelDate.Text = formattedDate;

            string greeting;
            if (now.Hour < 12)
            {
                greeting = "Selamat pagi, User!";
            }
            else if (now.Hour < 17)
            {
                greeting = "Selamat siang, User!";
            }
            else
            {
                greeting = "Selamat sore, User!";
            }

            labelGreetings.Text = greeting;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            btnExpand.Image = Properties.Resources.Collapse_Arrow;
            methodExpand = !methodExpand;
            timerDropDown.Start();
        }

        private void timerDropDown_Tick(object sender, EventArgs e)
        {
            int step = 10;
            if (methodExpand)
            {
                if (upbarLog.Height + step < upbarLog.MaximumSize.Height)
                {
                    upbarLog.Height += step;
                }
                else
                {
                    upbarLog.Height = upbarLog.MaximumSize.Height;
                    timerDropDown.Stop();
                }
            }
            else
            {

                if (upbarLog.Height - step > upbarLog.MinimumSize.Height)
                {
                    upbarLog.Height -= step;
                }
                else
                {
                    btnExpand.Image = Properties.Resources.Expand_Arrow;
                    upbarLog.Height = upbarLog.MinimumSize.Height;
                    timerDropDown.Stop();
                }
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
            SetButtonHoverEffects(btnLogOut, Properties.Resources.logoutpinkhover, Properties.Resources.logoutpink);
            SetButtonHoverEffects(btnEditCustomer, Properties.Resources.Search_Client_Hover, Properties.Resources.Search_Client);
            SetButtonHoverEffects(btnEditTopUp, Properties.Resources.Pay_Hover, Properties.Resources.Payment);
        }

        private void lblcust_MouseHover(object sender, EventArgs e)
        {
            lblcust.ForeColor = Color.DimGray;
        }

        private void lblcust_MouseLeave(object sender, EventArgs e)
        {
            lblcust.ForeColor = Color.White;
        }

        private void lbltop_MouseHover(object sender, EventArgs e)
        {
            lbltop.ForeColor = Color.DimGray;
        }

        private void lbltop_MouseLeave(object sender, EventArgs e)
        {
            lbltop.ForeColor = Color.White;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditCustomer form = new EditCustomer();
            form.Show();
        }

        private void btnEditTopUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditPembayaran form = new EditPembayaran();
            form.Show();
        }
    }
}
