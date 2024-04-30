using System;
using System.Drawing;

namespace bank
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gradientPanelLogin = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnShow = new System.Windows.Forms.PictureBox();
            this.lblSignUp = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabelSign = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblForgot = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnHide = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.PictureBox();
            this.bunifuLabelLogo = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbAdmin = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.pictureBoxPin = new System.Windows.Forms.PictureBox();
            this.bunifuPanelPin = new Bunifu.UI.WinForms.BunifuPanel();
            this.tbPin = new ZBobb.AlphaBlendTextBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.bunifuPanelPhone = new Bunifu.UI.WinForms.BunifuPanel();
            this.tbNumber = new ZBobb.AlphaBlendTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.gradientPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelLogin
            // 
            this.gradientPanelLogin.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanelLogin.BackgroundImage")));
            this.gradientPanelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanelLogin.BorderRadius = 1;
            this.gradientPanelLogin.Controls.Add(this.btnShow);
            this.gradientPanelLogin.Controls.Add(this.lblSignUp);
            this.gradientPanelLogin.Controls.Add(this.bunifuLabelSign);
            this.gradientPanelLogin.Controls.Add(this.lblForgot);
            this.gradientPanelLogin.Controls.Add(this.btnHide);
            this.gradientPanelLogin.Controls.Add(this.buttonLogin);
            this.gradientPanelLogin.Controls.Add(this.bunifuLabelLogo);
            this.gradientPanelLogin.Controls.Add(this.pictureBox1);
            this.gradientPanelLogin.Controls.Add(this.bunifuLabel1);
            this.gradientPanelLogin.Controls.Add(this.cbAdmin);
            this.gradientPanelLogin.Controls.Add(this.pictureBoxPin);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanelPin);
            this.gradientPanelLogin.Controls.Add(this.tbPin);
            this.gradientPanelLogin.Controls.Add(this.pictureBoxPhone);
            this.gradientPanelLogin.Controls.Add(this.bunifuPanelPhone);
            this.gradientPanelLogin.Controls.Add(this.tbNumber);
            this.gradientPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelLogin.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.gradientPanelLogin.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.gradientPanelLogin.GradientTopLeft = System.Drawing.Color.LightPink;
            this.gradientPanelLogin.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.gradientPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelLogin.Name = "gradientPanelLogin";
            this.gradientPanelLogin.Quality = 10;
            this.gradientPanelLogin.Size = new System.Drawing.Size(441, 624);
            this.gradientPanelLogin.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Image = global::bank.Properties.Resources.HideHover;
            this.btnShow.Location = new System.Drawing.Point(365, 324);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(30, 25);
            this.btnShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShow.TabIndex = 15;
            this.btnShow.TabStop = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AllowParentOverrides = false;
            this.lblSignUp.AutoEllipsis = false;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.Black;
            this.lblSignUp.Location = new System.Drawing.Point(274, 579);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSignUp.Size = new System.Drawing.Size(97, 21);
            this.lblSignUp.TabIndex = 14;
            this.lblSignUp.Text = "Sign Up here";
            this.lblSignUp.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSignUp.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            this.lblSignUp.MouseLeave += new System.EventHandler(this.lblSignUp_MouseLeave);
            this.lblSignUp.MouseHover += new System.EventHandler(this.lblSignUp_MouseHover);
            // 
            // bunifuLabelSign
            // 
            this.bunifuLabelSign.AllowParentOverrides = false;
            this.bunifuLabelSign.AutoEllipsis = false;
            this.bunifuLabelSign.CursorType = null;
            this.bunifuLabelSign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabelSign.ForeColor = System.Drawing.Color.White;
            this.bunifuLabelSign.Location = new System.Drawing.Point(72, 579);
            this.bunifuLabelSign.Name = "bunifuLabelSign";
            this.bunifuLabelSign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabelSign.Size = new System.Drawing.Size(196, 21);
            this.bunifuLabelSign.TabIndex = 13;
            this.bunifuLabelSign.Text = "Don’t have an account?";
            this.bunifuLabelSign.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabelSign.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblForgot
            // 
            this.lblForgot.AllowParentOverrides = false;
            this.lblForgot.AutoEllipsis = false;
            this.lblForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgot.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblForgot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.ForeColor = System.Drawing.Color.Black;
            this.lblForgot.Location = new System.Drawing.Point(309, 383);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblForgot.Size = new System.Drawing.Size(86, 21);
            this.lblForgot.TabIndex = 12;
            this.lblForgot.Text = "Forgot Pin?";
            this.lblForgot.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblForgot.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblForgot.Click += new System.EventHandler(this.lblForgot_Click);
            this.lblForgot.MouseLeave += new System.EventHandler(this.lblForgot_MouseLeave);
            this.lblForgot.MouseHover += new System.EventHandler(this.lblForgot_MouseHover);
            // 
            // btnHide
            // 
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.Location = new System.Drawing.Point(365, 324);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(30, 25);
            this.btnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHide.TabIndex = 11;
            this.btnHide.TabStop = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.Location = new System.Drawing.Point(119, 469);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(192, 74);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.buttonLogin_MouseLeave);
            this.buttonLogin.MouseHover += new System.EventHandler(this.buttonLogin_MouseHover);
            // 
            // bunifuLabelLogo
            // 
            this.bunifuLabelLogo.AllowParentOverrides = false;
            this.bunifuLabelLogo.AutoEllipsis = false;
            this.bunifuLabelLogo.CursorType = null;
            this.bunifuLabelLogo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabelLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabelLogo.Location = new System.Drawing.Point(150, 111);
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
            this.pictureBox1.Location = new System.Drawing.Point(150, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(73, 382);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(115, 21);
            this.bunifuLabel1.TabIndex = 7;
            this.bunifuLabel1.Text = "Administrator?";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AllowBindingControlAnimation = true;
            this.cbAdmin.AllowBindingControlColorChanges = false;
            this.cbAdmin.AllowBindingControlLocation = true;
            this.cbAdmin.AllowCheckBoxAnimation = false;
            this.cbAdmin.AllowCheckmarkAnimation = true;
            this.cbAdmin.AllowOnHoverStates = true;
            this.cbAdmin.AutoCheck = true;
            this.cbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.cbAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbAdmin.BackgroundImage")));
            this.cbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbAdmin.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbAdmin.BorderRadius = 12;
            this.cbAdmin.Checked = true;
            this.cbAdmin.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.cbAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAdmin.CustomCheckmarkImage = null;
            this.cbAdmin.Location = new System.Drawing.Point(37, 375);
            this.cbAdmin.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.OnCheck.BorderColor = System.Drawing.Color.White;
            this.cbAdmin.OnCheck.BorderRadius = 12;
            this.cbAdmin.OnCheck.BorderThickness = 2;
            this.cbAdmin.OnCheck.CheckBoxColor = System.Drawing.Color.White;
            this.cbAdmin.OnCheck.CheckmarkColor = System.Drawing.Color.DarkGray;
            this.cbAdmin.OnCheck.CheckmarkThickness = 2;
            this.cbAdmin.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.cbAdmin.OnDisable.BorderRadius = 12;
            this.cbAdmin.OnDisable.BorderThickness = 2;
            this.cbAdmin.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbAdmin.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.cbAdmin.OnDisable.CheckmarkThickness = 2;
            this.cbAdmin.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbAdmin.OnHoverChecked.BorderRadius = 12;
            this.cbAdmin.OnHoverChecked.BorderThickness = 2;
            this.cbAdmin.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbAdmin.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbAdmin.OnHoverChecked.CheckmarkThickness = 2;
            this.cbAdmin.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbAdmin.OnHoverUnchecked.BorderRadius = 12;
            this.cbAdmin.OnHoverUnchecked.BorderThickness = 1;
            this.cbAdmin.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbAdmin.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.cbAdmin.OnUncheck.BorderRadius = 12;
            this.cbAdmin.OnUncheck.BorderThickness = 1;
            this.cbAdmin.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbAdmin.Size = new System.Drawing.Size(29, 29);
            this.cbAdmin.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbAdmin.TabIndex = 6;
            this.cbAdmin.ThreeState = false;
            this.cbAdmin.ToolTipText = null;
            // 
            // pictureBoxPin
            // 
            this.pictureBoxPin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPin.Image")));
            this.pictureBoxPin.Location = new System.Drawing.Point(37, 310);
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
            this.bunifuPanelPin.Location = new System.Drawing.Point(34, 362);
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
            this.tbPin.Location = new System.Drawing.Point(87, 324);
            this.tbPin.Multiline = true;
            this.tbPin.Name = "tbPin";
            this.tbPin.PasswordChar = '●';
            this.tbPin.Size = new System.Drawing.Size(308, 38);
            this.tbPin.TabIndex = 3;
            this.tbPin.Text = "Pin";
            this.tbPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPin_KeyPress);
            this.tbPin.Enter += new System.EventHandler(this.tbPin_Enter);
            this.tbPin.Leave += new System.EventHandler(this.tbPin_Leave);
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhone.Image")));
            this.pictureBoxPhone.Location = new System.Drawing.Point(37, 236);
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
            this.bunifuPanelPhone.Location = new System.Drawing.Point(34, 288);
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
            this.tbNumber.Location = new System.Drawing.Point(87, 250);
            this.tbNumber.Multiline = true;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(308, 38);
            this.tbNumber.TabIndex = 0;
            this.tbNumber.Text = "Phone Number";
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            this.tbNumber.Enter += new System.EventHandler(this.tbNumber_Enter);
            this.tbNumber.Leave += new System.EventHandler(this.tbNumber_Leave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 624);
            this.Controls.Add(this.gradientPanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gradientPanelLogin.ResumeLayout(false);
            this.gradientPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            this.ResumeLayout(false);

        }
        
        // Untuk tbNumber
        private void tbNumber_Enter(object sender, EventArgs e)
        {
            if (tbNumber.Text == "Phone Number")
            {
                tbNumber.Text = "";
                tbNumber.ForeColor = System.Drawing.Color.White;
            }
        }

        private void tbNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNumber.Text))
            {
                tbNumber.Text = "Phone Number";
                tbNumber.ForeColor = System.Drawing.Color.White;
            }
        }
        
        // Untuk tbPin
        private void tbPin_Enter(object sender, EventArgs e)
        {
            if (tbPin.Text == "Pin")
            {
                tbPin.Text = "";
                tbPin.ForeColor = System.Drawing.Color.White;
                tbPin.PasswordChar = '●'; // Jika Anda ingin mengubah karakter password
            }
        }

        private void tbPin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPin.Text))
            {
                tbPin.Text = "Pin";
                tbPin.ForeColor = System.Drawing.Color.White;
                tbPin.PasswordChar = '\0'; // Mengembalikan karakter default
            }
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel gradientPanelLogin;
        private ZBobb.AlphaBlendTextBox tbNumber;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelPhone;
        private System.Windows.Forms.PictureBox pictureBoxPhone;
        private System.Windows.Forms.PictureBox pictureBoxPin;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanelPin;
        private ZBobb.AlphaBlendTextBox tbPin;
        private Bunifu.UI.WinForms.BunifuCheckBox cbAdmin;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabelLogo;
        private System.Windows.Forms.PictureBox buttonLogin;
        private System.Windows.Forms.PictureBox btnHide;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabelSign;
        private Bunifu.UI.WinForms.BunifuLabel lblForgot;
        private Bunifu.UI.WinForms.BunifuLabel lblSignUp;
        private System.Windows.Forms.PictureBox btnShow;
    }
}

