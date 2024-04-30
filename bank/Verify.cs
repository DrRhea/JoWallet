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
    public partial class Verify : Form
    {
        private readonly string nextAction;
        private int timeLeft = 30;

        public Verify(String nextAction)
        {
            this.nextAction = nextAction;
            InitializeComponent();     
        }

        private void ConfirmRegis_Load(object sender, EventArgs e)
        {
            StartCountdown();
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (nextAction == "Register")
            {
                this.Hide();
                Login form = new Login();
                form.Show();
            }
            else if (nextAction == "Forgot")
            {
                this.Hide();
                Forgot form = new Forgot();
                form.Show();
            }
        }

        private void buttonVerify_MouseHover(object sender, EventArgs e)
        {
            buttonVerify.Image = Properties.Resources.ButtonVerifyHover;
        }

        private void buttonVerify_MouseLeave(object sender, EventArgs e)
        {
            buttonVerify.Image = Properties.Resources.ButtonVerify;
        }

        private void timerResend_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblResend.Text = $"Resend OTP within {timeLeft} S";
            }
            else
            {
                timerResend.Stop();
                lblResend.Text = "Click here to resend OTP";
                lblResend.Font = new Font(lblResend.Font, FontStyle.Underline);
                lblResend.Cursor = Cursors.Hand;
            }
        }

        private void lblResend_Click(object sender, EventArgs e)
        {
            if (timeLeft == 0)
            {
                SendVerification();
                StartCountdown();
            }
        }

        private void SendVerification()
        {
            return;
            // Untuk OTP
        }

        private void StartCountdown()
        {
            timeLeft = 30; 
            timerResend.Start();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            if (nextAction == "Register")
            {
                this.Hide();
                SignUp form = new SignUp();
                form.Show();
            }
            else if (nextAction == "Forgot")
            {
                this.Hide();
                Login form = new Login();
                form.Show();
            }
        }

        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.White;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }
    }
}

