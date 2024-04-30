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
using Bunifu.UI.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite; 

namespace bank
{
    public partial class Profile : Form
    {
        private string actualAccountId = "1234567890";
        private string userName;

        public Profile()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        
        private string GetUserNameFromDatabase(int userId)
        {
            // Ambil string koneksi dari app.config
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Koneksi ke database SQLite
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Query untuk mengambil nama pengguna dari tabel user
                string query = "SELECT name FROM login WHERE id = @UserId";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                // Eksekusi query dan ambil hasil
                object result = command.ExecuteScalar();

                // Tutup koneksi
                connection.Close();

                // Kembalikan nama pengguna jika ada, atau nilai default jika tidak ada
                return result != null ? result.ToString() : "Nama Pengguna";
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
            
            // Retrieve user's name from the database
            userName = GetUserNameFromDatabase(1);

            // Update the labels
            lblName.Text = userName;
            lblUser.Text = userName;
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
