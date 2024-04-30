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
using System.Windows.Forms.VisualStyles;
using System.Data.SQLite;

namespace bank
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string tel = tbNumber.Text;
            string pin = tbPin.Text;

            if (cbAdmin.Checked)
            {
                // Penanganan login untuk admin
                if (IsAdminCredentialsCorrect(tel, pin))
                {
                    Admin adminForm = new Admin();
                    this.Hide();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Admin credentials are incorrect.");
                }
            }
            else
            {
                // Penanganan login untuk customer
                if (IsUserCredentialsValid(tel, pin))
                {
                    Menu customerForm = new Menu();
                    this.Hide();
                    customerForm.Show();
                }
                else
                {
                    MessageBox.Show("Customer credentials are incorrect");
                }
            }
        }

        private bool IsUserCredentialsValid(string tel, string pin)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM user WHERE tel = @Tel AND pin = @Pin";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Tel", tel);
                command.Parameters.AddWithValue("@Pin", pin);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        private bool IsAdminCredentialsCorrect(string username, string password)
        {
            return true; 
        }

        private bool IsCustomerCredentialsCorrect(string username, string password)
        {
            return IsUserCredentialsValid(username, password);
        }

        private void buttonLogin_MouseHover(object sender, EventArgs e)
        {
            buttonLogin.Image = Properties.Resources.ButtonLoginHover;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.Image = Properties.Resources.ButtonLogin;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            tbPin.PasswordChar = '\0';
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnShow.Visible = false;
            tbPin.PasswordChar = '●';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cbAdmin.Checked = false;
            btnShow.Visible = false;
            btnHide.Visible = true;
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Verify form = new Verify("Forgot");
            form.Show();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            this.Hide();
            form.Show();


        }

        private void lblForgot_MouseHover(object sender, EventArgs e)
        {
            lblForgot.ForeColor = Color.White;
            lblForgot.Font = new Font(lblForgot.Font, FontStyle.Underline);
        }

        private void lblForgot_MouseLeave(object sender, EventArgs e)
        {
            lblForgot.ForeColor = Color.Black;
            lblForgot.Font = new Font(lblForgot.Font, FontStyle.Regular);
        }

        private void lblSignUp_MouseHover(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.White;
            lblForgot.Font = new Font(lblForgot.Font, FontStyle.Underline);
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.Black;
            lblForgot.Font = new Font(lblForgot.Font, FontStyle.Regular);
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
    }
}
