namespace bank
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradientPanelLogin = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.dataGridHistory = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gradientPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // gradientPanelLogin
            // 
            this.gradientPanelLogin.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanelLogin.BackgroundImage")));
            this.gradientPanelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanelLogin.BorderRadius = 1;
            this.gradientPanelLogin.Controls.Add(this.btnPrint);
            this.gradientPanelLogin.Controls.Add(this.btnBack);
            this.gradientPanelLogin.Controls.Add(this.dataGridHistory);
            this.gradientPanelLogin.Controls.Add(this.bunifuLabel1);
            this.gradientPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelLogin.GradientBottomLeft = System.Drawing.Color.LightCoral;
            this.gradientPanelLogin.GradientBottomRight = System.Drawing.Color.PaleVioletRed;
            this.gradientPanelLogin.GradientTopLeft = System.Drawing.Color.HotPink;
            this.gradientPanelLogin.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gradientPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelLogin.Name = "gradientPanelLogin";
            this.gradientPanelLogin.Quality = 10;
            this.gradientPanelLogin.Size = new System.Drawing.Size(457, 663);
            this.gradientPanelLogin.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(120, 577);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(204, 74);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.TabStop = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(12, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 6;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // dataGridHistory
            // 
            this.dataGridHistory.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridHistory.ColumnHeadersHeight = 40;
            this.dataGridHistory.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridHistory.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridHistory.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridHistory.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridHistory.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridHistory.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridHistory.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridHistory.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridHistory.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridHistory.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridHistory.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridHistory.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridHistory.CurrentTheme.Name = null;
            this.dataGridHistory.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridHistory.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridHistory.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridHistory.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridHistory.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridHistory.EnableHeadersVisualStyles = false;
            this.dataGridHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridHistory.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridHistory.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridHistory.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridHistory.Location = new System.Drawing.Point(12, 98);
            this.dataGridHistory.Name = "dataGridHistory";
            this.dataGridHistory.RowHeadersVisible = false;
            this.dataGridHistory.RowTemplate.Height = 40;
            this.dataGridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHistory.Size = new System.Drawing.Size(433, 473);
            this.dataGridHistory.TabIndex = 5;
            this.dataGridHistory.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(89, 29);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(293, 40);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "History Transaction";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 663);
            this.Controls.Add(this.gradientPanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.gradientPanelLogin.ResumeLayout(false);
            this.gradientPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel gradientPanelLogin;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridHistory;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnPrint;
    }
}