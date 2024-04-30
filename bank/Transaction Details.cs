using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Drawing.Imaging;
using System.IO;
using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Layout.Properties;

namespace bank
{
    public partial class Transaction_Details : Form
    {
        private readonly string serviceType;

        public Transaction_Details(String serviceType)
        {
            InitializeComponent();
            this.serviceType = serviceType;
        }

        private void btnBuyMore_Click(object sender, EventArgs e)
        {
            if (serviceType == "Pulsa")
            {
                this.Hide();
                Pulsa form = new Pulsa();
                form.Show();
            }
            else if (serviceType == "PaketData")
            {
                this.Hide();
                PaketData form = new PaketData();
                form.Show();
            }
        }

        private void linkDownload_Click(object sender, EventArgs e)
        {
            //string transactionId = GetTransactionId(); blm ada, bikin lah
            //SavePanelToPdf(panelReceipt, transactionId);
        }

        private void SavePanelToPdf(Panel panel, string transactionId)
        {
            string filename = $"receipt_{transactionId}.pdf";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = filename,
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Save Receipt as PDF"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp = new Bitmap(panel.Width, panel.Height);
                    panel.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, panel.Width, panel.Height));

                    using (MemoryStream stream = new MemoryStream())
                    {
                        bmp.Save(stream, ImageFormat.Png);

                        PdfWriter writer = new PdfWriter(filename);
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf, PageSize.A4);
                        document.SetMargins(20, 20, 20, 20);

                        ImageData imageData = ImageDataFactory.Create(stream.ToArray());
                        iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(imageData);
                        document.Add(pdfImage);

                        document.Close();
                    }

                    MessageBox.Show("Receipt downloaded successfully.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to download receipt. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuyMore_MouseHover(object sender, EventArgs e)
        {
            btnBuyMore.Image = Properties.Resources.ButtonMoreHover;
        }

        private void btnBuyMore_MouseLeave(object sender, EventArgs e)
        {
            btnBuyMore.Image = Properties.Resources.Buy;
        }

        private void linkDownload_MouseHover(object sender, EventArgs e)
        {
            linkDownload.Font = new Font(linkDownload.Font, FontStyle.Bold);
        }

        private void linkDownload_MouseLeave(object sender, EventArgs e)
        {
            linkDownload.Font = new Font(linkDownload.Font, FontStyle.Underline);
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

        private void SetServiceDetails(String serviceType)
        {
            switch (serviceType)
            {
                case "Pulsa":
                    logoService.Image = Properties.Resources.pulsa;
                    lblService.Text = "Pulsa";
                    lblNumber.Text = "Phone Number";
                    lblPrice.Text = "Price";
                    lblPrice2.Text = "Total Price";
                    btnBuyMore.Visible = true;
                    break;
                case "PaketData":
                    logoService.Image = Properties.Resources.paket_data; 
                    lblService.Text = "Paket Data";
                    lblNumber.Text = "Phone Number";
                    lblPrice.Text = "Price";
                    lblPrice2.Text = "Total Price";
                    btnBuyMore.Visible = true;
                    break;
                case "Send":
                    logoService.Image = Properties.Resources.kirim;
                    lblService.Text = "Send Balance";
                    lblNumber.Text = "JoWallet ID";
                    lblPrice.Text = "Note";
                    lblPrice1.Text = "Money";
                    lblPrice2.Text = "Total Amount";
                    btnBuyMore.Visible = false;
                    break;
                case "TopUp":
                    logoService.Image = Properties.Resources.isi_saldo;
                    lblService.Text = "Top Up Balance";
                    lblNumber.Text = "JoWallet ID";
                    lblPrice.Text = "Amount";
                    lblPrice2.Text = "Total Amount";
                    lblMethod.Text = "Transfer";
                    btnBuyMore.Visible = false;
                    break;
                case "Request":
                    logoService.Image = Properties.Resources.minta;
                    logoCompleted.Image = Properties.Resources.Clock;
                    lblCompleted1.Text = "Pending";
                    lblCompleted2.Text = "Transaction Pending";
                    lblService.Text = "Request Balance";
                    lblNumber.Text = "JoWallet ID";
                    lblPrice.Text = "Amount";
                    lblPrice2.Text = "Total Amount";
                    lblMethod.Text = "xxxxxxxxxx";// method pembayaran, karena request diganti jadi no id si request
                    lblPayment.Text = "Requested";
                    lblInfromation.Text = "Request Information";
                    btnBuyMore.Visible = false;
                    break;
            }
        }

        private void Transaction_Details_Load(object sender, EventArgs e)
        {
            SetServiceDetails(serviceType);
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm");
        }
    }
}
