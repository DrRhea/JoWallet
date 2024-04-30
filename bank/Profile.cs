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
        private string virtualAccountId = "";
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
        
        private string GetVirtualAccountIdFromDatabase(int userId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ba.virtual_id FROM bank_acc ba JOIN login l ON ba.id_user = l.id_user WHERE l.id = @UserId";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                object result = command.ExecuteScalar();

                connection.Close();

                return result != null ? result.ToString() : "Tidak ada Virtual ID";
            }
        }
        
        private string GetExpirationFromDatabase(int userId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ba.month, ba.year FROM bank_acc ba JOIN login l ON ba.id_user = l.id_user WHERE l.id = @UserId";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) // Cek apakah ada baris hasil
                    {
                        int month = reader.GetInt32(0); // Ambil nilai dari kolom pertama (indeks 0)
                        int year = reader.GetInt32(1); // Ambil nilai dari kolom kedua (indeks 1)
                        return $"{month:D2}/{year % 100:D2}";
                    }
                    else
                    {
                        return "00/00";
                    }
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

            userName = GetUserNameFromDatabase(1);
            lblName.Text = userName;
            lblUser.Text = userName;

            virtualAccountId = GetVirtualAccountIdFromDatabase(1);
            lblid.Text = virtualAccountId;
            lblVirtualID.Text = virtualAccountId;

            lblExpierd.Text = GetExpirationFromDatabase(1);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnShow.Visible = false;
            lblVirtualID.Text = virtualAccountId;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            lblVirtualID.Text = new string('●', virtualAccountId.Length);
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
