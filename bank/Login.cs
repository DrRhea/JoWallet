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
            string username = tbNumber.Text;
            string password = tbPin.Text;

            if (cbAdmin.Checked)
            {
                // Penanganan login untuk admin
                if (IsAdminCredentialsCorrect(username, password))
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
                if (IsUserCredentialsValid(username, password))
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

        private bool IsUserCredentialsValid(string username, string password)
        {
            // Ambil string koneksi dari app.config
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Koneksi ke database SQLite
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Query untuk memeriksa keberadaan user dengan username dan password yang diberikan
                string query = "SELECT COUNT(*) FROM user WHERE user = @Username AND pin = @Password";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                // Eksekusi query dan periksa hasil
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
