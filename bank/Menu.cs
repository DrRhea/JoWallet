using CircularProgressBar;
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
    public partial class Menu : Form
    
    {
        bool siderbarExpand;
        bool transactionCollapsed = false;
        bool accountCollapsed = false;

        public string actualSaldo = "999.110";
        private string userName;

        public Menu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            userName = GetUserNameFromDatabase();
            UpdateDateTimeAndGreeting(userName);
            
            Timer timer = new Timer();
            timer.Interval = 60000; 
            timer.Tick += (s, args) => UpdateDateTimeAndGreeting(userName);
            timer.Start();
            UpdateDateTimeAndGreeting(userName);

            btnHide.Visible = false;
            lblGreet.Visible = false;
            buttonAccount.Enabled = false;
            buttonTransaction.Enabled = false;
            buttonShop.Enabled = false;
            buttonHome.Enabled = false;

            decimal saldo = 999000;
            setRoles(saldo);
        }
        
        private string GetUserNameFromDatabase()
        {
            string tel = ""; // Gantilah dengan nomor telepon pengguna yang login

            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string userName = "";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name FROM login WHERE id = 1";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Tel", tel);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    userName = result.ToString();
                }
            }

            return userName;
        }

        private void setRoles(decimal amount)
        {
            if (amount > 10000000) 
            {
                lblRole.Image = Properties.Resources.Boss;
            }
            else if (amount > 1000000)
            {
                lblRole.Image = Properties.Resources.Bestie;
            }
            else if (amount > 500000) 
            {
                lblRole.Image = Properties.Resources.Pro;
            }
            else if (amount > 100000)
            {
                lblRole.Image = Properties.Resources.Basic;
            }
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                sidebar.Width -= 300;
                if(sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    siderbarExpand = false;
                    timerSidebar.Stop();
                    buttonAccount.Enabled = false;
                    buttonTransaction.Enabled = false;
                    buttonShop.Enabled = false;
                    buttonHome.Enabled = false;
                    labelGreetings.Visible = true;
                    lblGreet.Visible = true;
                    btnData.Enabled = true;
                    btnPulsa.Enabled = true;
                    btnHide.Enabled = true;
                    btnShow.Enabled = false;
                }
            }
            else
            {
                sidebar.Width += 300;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    siderbarExpand = true;
                    timerSidebar.Stop();
                    buttonAccount.Enabled = true;
                    buttonTransaction.Enabled = true;
                    buttonShop.Enabled = true;
                    buttonHome.Enabled = true;
                    labelGreetings.Visible = false;
                    lblGreet.Visible = false;
                    btnData.Enabled = false;
                    btnPulsa.Enabled = false;
                    btnHide.Enabled = false;
                    btnShow.Enabled = false;
                }
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            btnSidebar.Image = Properties.Resources.Drag_List_Up;
            timerSidebar.Start();
        }

        private void btnSidebar_MouseHover(object sender, EventArgs e)
        {
            btnSidebar.Image = Properties.Resources.Drag_List_DownHover;
        }

        private void btnSidebar_MouseLeave(object sender, EventArgs e)
        {
            btnSidebar.Image = Properties.Resources.Drag_List_Down;
        }

        private void transactionTimer_Tick(object sender, EventArgs e)
        {
            if (transactionCollapsed)
            {
                transactionContainer.Height += 200;
                if (transactionContainer.Height == transactionContainer.MaximumSize.Height)
                {
                    transactionCollapsed = false;
                    transactionTimer.Stop();
                }
            }
            else
            {
                transactionContainer.Height -= 200;
                if (transactionContainer.Height == transactionContainer.MinimumSize.Height)
                {
                    transactionCollapsed = true;
                    transactionTimer.Stop();
                }
            }
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            transactionTimer.Start();
        }

        private void buttonIsiSaldo_Click(object sender, EventArgs e)
        {
            this.Hide();
            TopUp form = new TopUp();
            form.Show();
        }

        private void buttonKirimSaldo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Send form = new Send();
            form.Show();
        }

        private void buttonMintaSaldo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Request form = new Request();
            form.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            History form = new History();
            form.Show();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile form = new Profile();
            form.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            if (accountCollapsed)
            {
                AccountContainer.Height += 100;
                if (AccountContainer.Height >= AccountContainer.MaximumSize.Height)
                {
                    accountCollapsed = false;
                    timerAccount.Stop();
                }
            }
            else
            {
                AccountContainer.Height -= 100;
                if (AccountContainer.Height <= AccountContainer.MinimumSize.Height)
                {
                    accountCollapsed = true;
                    timerAccount.Stop();
                }
            }
        }

        private void timerAccount_Tick(object sender, EventArgs e)
        {
            timerAccount.Start();
        }

        private void UpdateDateTimeAndGreeting(string name)
        {
            DateTime now = DateTime.Now;

            string formattedDate = now.ToString("ddd, dd MMMM");
            labelDate.Text = formattedDate;

            string greeting = "";
            if (now.Hour < 12)
            {
                greeting = $"Selamat pagi, {name}!";
            }
            else if (now.Hour < 17)
            {
                greeting = $"Selamat siang, {name}!";
            }
            else
            {
                greeting = $"Selamat sore, {name}!";
            }

            labelGreetings.Text = greeting;
            lblGreet.Text = greeting;
        }

        private void account_MouseHover(object sender, EventArgs e)
        {
            account.Image = Properties.Resources.Account;
        }

        private void account_MouseLeave(object sender, EventArgs e)
        {
            account.Image = Properties.Resources.Test_AccountHover;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            lblSaldo.Text = new string('●', actualSaldo.Length);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            btnShow.Visible = false;
            lblSaldo.Text = actualSaldo;
        }

        private void btnPulsa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pulsa form = new Pulsa();
            form.Show();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaketData form = new PaketData();
            form.Show();
        }

        private void btnPulsa_MouseHover(object sender, EventArgs e)
        {
            btnPulsa.Image = Properties.Resources.pulsa_pink;
            lblPulsa.ForeColor = Color.Pink;
        }

        private void btnPulsa_MouseLeave(object sender, EventArgs e)
        {
            btnPulsa.Image = Properties.Resources.pulsa;
            lblPulsa.ForeColor = Color.Black;
        }

        private void btnData_MouseHover(object sender, EventArgs e)
        {
            btnData.Image = Properties.Resources.paket_data_pink;
            lblData.ForeColor = Color.Pink;
            lblData2.ForeColor = Color.Pink;
        }

        private void btnData_MouseLeave(object sender, EventArgs e)
        {
            btnData.Image = Properties.Resources.paket_data;
            lblData.ForeColor = Color.Black;
            lblData2.ForeColor = Color.Black;
        }

        private void buttonShop_MouseHover(object sender, EventArgs e)
        {
            buttonShop.Text = "         Coming Soon...";
        }

        private void buttonShop_MouseLeave(object sender, EventArgs e)
        {
            buttonShop.Text = "         Shop";
        }

        private void btnMore_MouseHover(object sender, EventArgs e)
        {
            lblMore.ForeColor = Color.Pink;
            btnMore.Image = Properties.Resources.More_pink;
        }

        private void btnMore_MouseLeave(object sender, EventArgs e)
        {
            lblMore.ForeColor = Color.Black;
            btnMore.Image = Properties.Resources.MoreHover;
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            TopUp form = new TopUp();
            form.Show();
        }

        private void btnTopUp_MouseHover(object sender, EventArgs e)
        {
            btnTopUp.Image = Properties.Resources.isi_saldo_pink;
            lblIsi.ForeColor = Color.Pink;
        }

        private void btnTopUp_MouseLeave(object sender, EventArgs e)
        {
            btnTopUp.Image = Properties.Resources.isi_saldo;
            lblIsi.ForeColor = Color.Black;
        }
    }
}
