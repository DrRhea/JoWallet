namespace bank
{
    partial class Pin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradientPanelLogin = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.PictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnShow = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxPin = new System.Windows.Forms.PictureBox();
            this.bunifuPanelPin = new Bunifu.UI.WinForms.BunifuPanel();
            this.tbPin = new ZBobb.AlphaBlendTextBox();
            this.gradientPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).BeginInit();
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
            this.gradientPanelLogin.Controls.Add(this.btnCancel);
            this.gradientPanelLogin.Controls.Add(this.btnOK);
            this.gradientPanelLogin.Controls.Add(this.bunifuLabel2);
            this.gradientPanelLogin.Controls.Add(this.btnShow);
            this.gradientPanelLogin.Controls.Add(this.btnHide);
            this.gradientPanelLogin.Controls.Add(this.pictureBoxPin);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanelPin);
            this.gradientPanelLogin.Controls.Add(this.tbPin);
            this.gradientPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelLogin.GradientBottomLeft = System.Drawing.Color.LightCoral;
            this.gradientPanelLogin.GradientBottomRight = System.Drawing.Color.PaleVioletRed;
            this.gradientPanelLogin.GradientTopLeft = System.Drawing.Color.Violet;
            this.gradientPanelLogin.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gradientPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelLogin.Name = "gradientPanelLogin";
            this.gradientPanelLogin.Quality = 10;
            this.gradientPanelLogin.Size = new System.Drawing.Size(400, 200);
            this.gradientPanelLogin.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::bank.Properties.Resources.ButtonCancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 74);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::bank.Properties.Resources.ButtonOK;
            this.btnOK.Location = new System.Drawing.Point(-4, 123);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(190, 74);
            this.btnOK.TabIndex = 22;
            this.btnOK.TabStop = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseLeave += new System.EventHandler(this.btnOK_MouseLeave);
            this.btnOK.MouseHover += new System.EventHandler(this.btnOK_MouseHover);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel2.Location = new System.Drawing.Point(131, 12);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(138, 40);
            this.bunifuLabel2.TabIndex = 21;
            this.bunifuLabel2.Text = "Insert Pin";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnShow
            // 
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Image = global::bank.Properties.Resources.HideHover;
            this.btnShow.Location = new System.Drawing.Point(346, 76);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(30, 25);
            this.btnShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShow.TabIndex = 20;
            this.btnShow.TabStop = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.Location = new System.Drawing.Point(346, 76);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(30, 25);
            this.btnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHide.TabIndex = 19;
            this.btnHide.TabStop = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // pictureBoxPin
            // 
            this.pictureBoxPin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPin.Image")));
            this.pictureBoxPin.Location = new System.Drawing.Point(31, 62);
            this.pictureBoxPin.Name = "pictureBoxPin";
            this.pictureBoxPin.Size = new System.Drawing.Size(44, 46);
            this.pictureBoxPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPin.TabIndex = 18;
            this.pictureBoxPin.TabStop = false;
            // 
            // bunifuPanelPin
            // 
            this.bunifuPanelPin.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanelPin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanelPin.BackgroundImage")));
            this.bunifuPanelPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanelPin.BorderColor = System.Drawing.Color.White;
            this.bunifuPanelPin.BorderRadius = 3;
            this.bunifuPanelPin.BorderThickness = 1;
            this.bunifuPanelPin.Location = new System.Drawing.Point(28, 114);
            this.bunifuPanelPin.Name = "bunifuPanelPin";
            this.bunifuPanelPin.ShowBorders = true;
            this.bunifuPanelPin.Size = new System.Drawing.Size(348, 3);
            this.bunifuPanelPin.TabIndex = 17;
            // 
            // tbPin
            // 
            this.tbPin.BackAlpha = 0;
            this.tbPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPin.ForeColor = System.Drawing.Color.White;
            this.tbPin.Location = new System.Drawing.Point(81, 76);
            this.tbPin.Multiline = true;
            this.tbPin.Name = "tbPin";
            this.tbPin.PasswordChar = '●';
            this.tbPin.Size = new System.Drawing.Size(272, 38);
            this.tbPin.TabIndex = 16;
            this.tbPin.Text = "Pin";
            this.tbPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPin_KeyPress);
            // 
            // Pin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.gradientPanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pin";
            this.Load += new System.EventHandler(this.Pin_Load);
            this.gradientPanelLogin.ResumeLayout(false);
            this.gradientPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel gradientPanelLogin;
        private System.Windows.Forms.PictureBox btnShow;
        private System.Windows.Forms.PictureBox btnHide;
        private System.Windows.Forms.PictureBox pictureBoxPin;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelPin;
        private ZBobb.AlphaBlendTextBox tbPin;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.PictureBox btnOK;
        private System.Windows.Forms.PictureBox btnCancel;
    }
}