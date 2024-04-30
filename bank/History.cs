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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.Show();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.BackHover;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.Back;
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            btnPrint.Image = Properties.Resources.ButtonPrint;
        }

        private void btnPrint_MouseLeave(object sender, EventArgs e)
        {
            btnPrint.Image = Properties.Resources.ButtoPrint;
        }
    }
}
