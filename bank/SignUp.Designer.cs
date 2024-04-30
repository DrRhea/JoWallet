namespace bank
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradientPanelLogin = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.buttonRegister = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tbName = new ZBobb.AlphaBlendTextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblLogin = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabelSign = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabelLogo = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPin = new System.Windows.Forms.PictureBox();
            this.bunifuPanelPin = new Bunifu.UI.WinForms.BunifuPanel();
            this.tbPin = new ZBobb.AlphaBlendTextBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.bunifuPanelPhone = new Bunifu.UI.WinForms.BunifuPanel();
            this.tbNumber = new ZBobb.AlphaBlendTextBox();
            this.gradientPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
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
            this.gradientPanelLogin.Controls.Add(this.buttonRegister);
            this.gradientPanelLogin.Controls.Add(this.btnShow);
            this.gradientPanelLogin.Controls.Add(this.btnHide);
            this.gradientPanelLogin.Controls.Add(this.pictureBox2);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanel1);
            this.gradientPanelLogin.Controls.Add(this.tbName);
            this.gradientPanelLogin.Controls.Add(this.bunifuLabel2);
            this.gradientPanelLogin.Controls.Add(this.lblLogin);
            this.gradientPanelLogin.Controls.Add(this.bunifuLabelSign);
            this.gradientPanelLogin.Controls.Add(this.bunifuLabelLogo);
            this.gradientPanelLogin.Controls.Add(this.pictureBox1);
            this.gradientPanelLogin.Controls.Add(this.pictureBoxPin);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanelPin);
            this.gradientPanelLogin.Controls.Add(this.tbPin);
            this.gradientPanelLogin.Controls.Add(this.pictureBoxPhone);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanelPhone);
            this.gradientPanelLogin.Controls.Add(this.tbNumber);
            this.gradientPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelLogin.GradientBottomLeft = System.Drawing.Color.LightCoral;
            this.gradientPanelLogin.GradientBottomRight = System.Drawing.Color.PaleVioletRed;
            this.gradientPanelLogin.GradientTopLeft = System.Drawing.Color.HotPink;
            this.gradientPanelLogin.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gradientPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelLogin.Name = "gradientPanelLogin";
            this.gradientPanelLogin.Quality = 10;
            this.gradientPanelLogin.Size = new System.Drawing.Size(457, 663);
            this.gradientPanelLogin.TabIndex = 1;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegister.Image")));
            this.buttonRegister.Location = new System.Drawing.Point(125, 497);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(192, 74);
            this.buttonRegister.TabIndex = 28;
            this.buttonRegister.TabStop = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            this.buttonRegister.MouseLeave += new System.EventHandler(this.buttonRegister_MouseLeave);
            this.buttonRegister.MouseHover += new System.EventHandler(this.buttonRegister_MouseHover);
            // 
            // btnShow
            // 
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Image = global::bank.Properties.Resources.HideHover;
            this.btnShow.Location = new System.Drawing.Point(375, 383);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(30, 25);
            this.btnShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShow.TabIndex = 25;
            this.btnShow.TabStop = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.Location = new System.Drawing.Point(375, 383);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(30, 25);
            this.btnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHide.TabIndex = 24;
            this.btnHide.TabStop = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Location = new System.Drawing.Point(44, 295);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(361, 3);
            this.bunifuPanel1.TabIndex = 18;
            // 
            // tbName
            // 
            this.tbName.BackAlpha = 0;
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(97, 257);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(308, 38);
            this.tbName.TabIndex = 17;
            this.tbName.Text = "Name";
            
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel2.Location = new System.Drawing.Point(164, 158);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(124, 40);
            this.bunifuLabel2.TabIndex = 16;
            this.bunifuLabel2.Text = "Register";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblLogin
            // 
            this.lblLogin.AllowParentOverrides = false;
            this.lblLogin.AutoEllipsis = false;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(294, 601);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLogin.Size = new System.Drawing.Size(80, 21);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "Login here";
            this.lblLogin.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblLogin.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblLogin_MouseLeave);
            this.lblLogin.MouseHover += new System.EventHandler(this.lblLogin_MouseHover);
            // 
            // bunifuLabelSign
            // 
            this.bunifuLabelSign.AllowParentOverrides = false;
            this.bunifuLabelSign.AutoEllipsis = false;
            this.bunifuLabelSign.CursorType = null;
            this.bunifuLabelSign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabelSign.ForeColor = System.Drawing.Color.White;
            this.bunifuLabelSign.Location = new System.Drawing.Point(72, 601);
            this.bunifuLabelSign.Name = "bunifuLabelSign";
            this.bunifuLabelSign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabelSign.Size = new System.Drawing.Size(216, 21);
            this.bunifuLabelSign.TabIndex = 13;
            this.bunifuLabelSign.Text = "Already have an account ?";
            this.bunifuLabelSign.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabelSign.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabelLogo
            // 
            this.bunifuLabelLogo.AllowParentOverrides = false;
            this.bunifuLabelLogo.AutoEllipsis = false;
            this.bunifuLabelLogo.CursorType = null;
            this.bunifuLabelLogo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabelLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabelLogo.Location = new System.Drawing.Point(202, 45);
            this.bunifuLabelLogo.Name = "bunifuLabelLogo";
            this.bunifuLabelLogo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabelLogo.Size = new System.Drawing.Size(136, 39);
            this.bunifuLabelLogo.TabIndex = 9;
            this.bunifuLabelLogo.Text = "JoWallet";
            this.bunifuLabelLogo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabelLogo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPin
            // 
            this.pictureBoxPin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPin.Image")));
            this.pictureBoxPin.Location = new System.Drawing.Point(47, 369);
            this.pictureBoxPin.Name = "pictureBoxPin";
            this.pictureBoxPin.Size = new System.Drawing.Size(44, 46);
            this.pictureBoxPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPin.TabIndex = 5;
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
            this.bunifuPanelPin.Location = new System.Drawing.Point(44, 421);
            this.bunifuPanelPin.Name = "bunifuPanelPin";
            this.bunifuPanelPin.ShowBorders = true;
            this.bunifuPanelPin.Size = new System.Drawing.Size(361, 3);
            this.bunifuPanelPin.TabIndex = 4;
            // 
            // tbPin
            // 
            this.tbPin.BackAlpha = 0;
            this.tbPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPin.ForeColor = System.Drawing.Color.White;
            this.tbPin.Location = new System.Drawing.Point(97, 383);
            this.tbPin.Multiline = true;
            this.tbPin.Name = "tbPin";
            this.tbPin.PasswordChar = '●';
            this.tbPin.Size = new System.Drawing.Size(308, 38);
            this.tbPin.TabIndex = 3;
            this.tbPin.Text = "Pin";
            this.tbPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPin_KeyPress);
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhone.Image")));
            this.pictureBoxPhone.Location = new System.Drawing.Point(47, 308);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(44, 46);
            this.pictureBoxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhone.TabIndex = 2;
            this.pictureBoxPhone.TabStop = false;
            // 
            // bunifuPanelPhone
            // 
            this.bunifuPanelPhone.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanelPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanelPhone.BackgroundImage")));
            this.bunifuPanelPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanelPhone.BorderColor = System.Drawing.Color.White;
            this.bunifuPanelPhone.BorderRadius = 3;
            this.bunifuPanelPhone.BorderThickness = 1;
            this.bunifuPanelPhone.Location = new System.Drawing.Point(44, 360);
            this.bunifuPanelPhone.Name = "bunifuPanelPhone";
            this.bunifuPanelPhone.ShowBorders = true;
            this.bunifuPanelPhone.Size = new System.Drawing.Size(361, 3);
            this.bunifuPanelPhone.TabIndex = 1;
            // 
            // tbNumber
            // 
            this.tbNumber.BackAlpha = 0;
            this.tbNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.ForeColor = System.Drawing.Color.White;
            this.tbNumber.Location = new System.Drawing.Point(97, 322);
            this.tbNumber.Multiline = true;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(308, 38);
            this.tbNumber.TabIndex = 0;
            this.tbNumber.Text = "Phone Number";
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 663);
            this.Controls.Add(this.gradientPanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.gradientPanelLogin.ResumeLayout(false);
            this.gradientPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel lblLogin;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabelSign;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxPin;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelPin;
        private ZBobb.AlphaBlendTextBox tbPin;
        private System.Windows.Forms.PictureBox pictureBoxPhone;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelPhone;
        private ZBobb.AlphaBlendTextBox tbNumber;
        private Bunifu.UI.WinForms.BunifuGradientPanel gradientPanelLogin;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private ZBobb.AlphaBlendTextBox tbName;
        private System.Windows.Forms.PictureBox btnShow;
        private System.Windows.Forms.PictureBox btnHide;
        private System.Windows.Forms.PictureBox buttonRegister;
    }
}