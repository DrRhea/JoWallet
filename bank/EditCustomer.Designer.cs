namespace bank
{
    partial class EditCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gradientPanelLogin = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.dataGridCustomer = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradientPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelLogin
            // 
            this.gradientPanelLogin.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanelLogin.BackgroundImage")));
            this.gradientPanelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanelLogin.BorderRadius = 1;
            this.gradientPanelLogin.Controls.Add(this.btnDelete);
            this.gradientPanelLogin.Controls.Add(this.btnPrint);
            this.gradientPanelLogin.Controls.Add(this.btnBack);
            this.gradientPanelLogin.Controls.Add(this.dataGridCustomer);
            this.gradientPanelLogin.Controls.Add(this.bunifuLabel1);
            this.gradientPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelLogin.GradientBottomLeft = System.Drawing.SystemColors.ActiveCaption;
            this.gradientPanelLogin.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.gradientPanelLogin.GradientTopLeft = System.Drawing.Color.SlateGray;
            this.gradientPanelLogin.GradientTopRight = System.Drawing.Color.Silver;
            this.gradientPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelLogin.Name = "gradientPanelLogin";
            this.gradientPanelLogin.Quality = 10;
            this.gradientPanelLogin.Size = new System.Drawing.Size(441, 624);
            this.gradientPanelLogin.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = global::bank.Properties.Resources.ButtonDelete;
            this.btnDelete.Location = new System.Drawing.Point(233, 547);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 95);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(36, 547);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(168, 95);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPrint.TabIndex = 11;
            this.btnPrint.TabStop = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(10, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 10;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCustomer.ColumnHeadersHeight = 40;
            this.dataGridCustomer.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridCustomer.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridCustomer.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridCustomer.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridCustomer.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCustomer.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridCustomer.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridCustomer.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridCustomer.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridCustomer.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridCustomer.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridCustomer.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridCustomer.CurrentTheme.Name = null;
            this.dataGridCustomer.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCustomer.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridCustomer.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridCustomer.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridCustomer.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCustomer.EnableHeadersVisualStyles = false;
            this.dataGridCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridCustomer.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridCustomer.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridCustomer.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridCustomer.Location = new System.Drawing.Point(12, 78);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RowHeadersVisible = false;
            this.dataGridCustomer.RowTemplate.Height = 40;
            this.dataGridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomer.Size = new System.Drawing.Size(417, 463);
            this.dataGridCustomer.TabIndex = 9;
            this.dataGridCustomer.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(114, 22);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(220, 40);
            this.bunifuLabel1.TabIndex = 8;
            this.bunifuLabel1.Text = "Edit Customer";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 624);
            this.Controls.Add(this.gradientPanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.gradientPanelLogin.ResumeLayout(false);
            this.gradientPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel gradientPanelLogin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox btnPrint;
        private System.Windows.Forms.PictureBox btnBack;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridCustomer;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox btnDelete;
    }
}