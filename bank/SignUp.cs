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
using System.Data.SQLite;

namespace bank
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            btnShow.Visible = false;
        }

        private void buttonRegister_MouseHover(object sender, EventArgs e)
        {
            buttonRegister.Image = Properties.Resources.ButtonRegisterHover;
        }

        private void buttonRegister_MouseLeave(object sender, EventArgs e)
        {
            buttonRegister.Image = Properties.Resources.ButtonRegister;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari kontrol input
            string username = tbName.Text; // Ubah tbUsername menjadi tbName
            string phoneNumber = tbNumber.Text;
            string password = tbPin.Text;

            // Panggil fungsi untuk menyimpan data
            SimpanData(username, phoneNumber, password);

            // Tampilkan formulir verifikasi atau formulir lain yang diperlukan
            Verify form = new Verify("Register");
            this.Hide();
            form.Show();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();         
        }

        private void lblLogin_MouseHover(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.White;
            lblLogin.Font = new Font(lblLogin.Font, FontStyle.Underline);
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.Black;
            lblLogin.Font = new Font(lblLogin.Font, FontStyle.Regular);
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

        private void tbPinRetry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void SimpanData(string username, string phoneNumber, string password)
        {
            // Ambil string koneksi dari app.config
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Koneksi ke database SQLite
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            // Query untuk menyimpan data ke dalam tabel user
            string query = "INSERT INTO user (user, tel, pin) VALUES (@Username, @PhoneNumber, @Password)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@Password", password);

            // Eksekusi query
            command.ExecuteNonQuery();

            // Tutup koneksi
            connection.Close();
        }
        
    }
}
