namespace bank
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnEditTopUp = new System.Windows.Forms.PictureBox();
            this.gradientPanelLogin = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lbltop = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblcust = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnEditCustomer = new System.Windows.Forms.PictureBox();
            this.labelDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelGreetings = new Bunifu.UI.WinForms.BunifuLabel();
            this.upbarLog = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.btnExpand = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerDropDown = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditTopUp)).BeginInit();
            this.gradientPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.upbarLog.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditTopUp
            // 
            this.btnEditTopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTopUp.Image = global::bank.Properties.Resources.Payment;
            this.btnEditTopUp.Location = new System.Drawing.Point(254, 309);
            this.btnEditTopUp.Name = "btnEditTopUp";
            this.btnEditTopUp.Size = new System.Drawing.Size(132, 117);
            this.btnEditTopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditTopUp.TabIndex = 6;
            this.btnEditTopUp.TabStop = false;
            this.btnEditTopUp.Click += new System.EventHandler(this.btnEditTopUp_Click);
            // 
            // gradientPanelLogin
            // 
            this.gradientPanelLogin.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanelLogin.BackgroundImage")));
            this.gradientPanelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanelLogin.BorderRadius = 1;
            this.gradientPanelLogin.Controls.Add(this.lbltop);
            this.gradientPanelLogin.Controls.Add(this.lblcust);
            this.gradientPanelLogin.Controls.Add(this.btnEditCustomer);
            this.gradientPanelLogin.Controls.Add(this.labelDate);
            this.gradientPanelLogin.Controls.Add(this.pictureBox2);
            this.gradientPanelLogin.Controls.Add(this.labelGreetings);
            this.gradientPanelLogin.Controls.Add(this.upbarLog);
            this.gradientPanelLogin.Controls.Add(this.btnEditTopUp);
            this.gradientPanelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelLogin.GradientBottomLeft = System.Drawing.SystemColors.ActiveCaption;
            this.gradientPanelLogin.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.gradientPanelLogin.GradientTopLeft = System.Drawing.Color.SlateGray;
            this.gradientPanelLogin.GradientTopRight = System.Drawing.Color.Silver;
            this.gradientPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelLogin.MaximumSize = new System.Drawing.Size(441, 624);
            this.gradientPanelLogin.Name = "gradientPanelLogin";
            this.gradientPanelLogin.Quality = 10;
            this.gradientPanelLogin.Size = new System.Drawing.Size(441, 624);
            this.gradientPanelLogin.TabIndex = 6;
            // 
            // lbltop
            // 
            this.lbltop.AllowParentOverrides = false;
            this.lbltop.AutoEllipsis = false;
            this.lbltop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbltop.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lbltop.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop.ForeColor = System.Drawing.Color.White;
            this.lbltop.Location = new System.Drawing.Point(266, 432);
            this.lbltop.Name = "lbltop";
            this.lbltop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbltop.Size = new System.Drawing.Size(110, 24);
            this.lbltop.TabIndex = 26;
            this.lbltop.Text = "Edit Top Up";
            this.lbltop.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbltop.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbltop.MouseLeave += new System.EventHandler(this.lbltop_MouseLeave);
            this.lbltop.MouseHover += new System.EventHandler(this.lbltop_MouseHover);
            // 
            // lblcust
            // 
            this.lblcust.AllowParentOverrides = false;
            this.lblcust.AutoEllipsis = false;
            this.lblcust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcust.CursorType = System.Windows.Forms.Cursors.Hand;
            this.lblcust.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust.ForeColor = System.Drawing.Color.White;
            this.lblcust.Location = new System.Drawing.Point(55, 432);
            this.lblcust.Name = "lblcust";
            this.lblcust.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblcust.Size = new System.Drawing.Size(141, 24);
            this.lblcust.TabIndex = 25;
            this.lblcust.Text = "Edit Customer";
            this.lblcust.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblcust.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblcust.MouseLeave += new System.EventHandler(this.lblcust_MouseLeave);
            this.lblcust.MouseHover += new System.EventHandler(this.lblcust_MouseHover);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCustomer.Image = global::bank.Properties.Resources.Search_Client;
            this.btnEditCustomer.Location = new System.Drawing.Point(63, 309);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(125, 117);
            this.btnEditCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditCustomer.TabIndex = 24;
            this.btnEditCustomer.TabStop = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // labelDate
            // 
            this.labelDate.AllowParentOverrides = false;
            this.labelDate.AutoEllipsis = false;
            this.labelDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDate.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(29, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDate.Size = new System.Drawing.Size(83, 21);
            this.labelDate.TabIndex = 23;
            this.labelDate.Text = "Th, 19 April";
            this.labelDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(195, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // labelGreetings
            // 
            this.labelGreetings.AllowParentOverrides = false;
            this.labelGreetings.AutoEllipsis = false;
            this.labelGreetings.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelGreetings.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelGreetings.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreetings.ForeColor = System.Drawing.Color.White;
            this.labelGreetings.Location = new System.Drawing.Point(126, 232);
            this.labelGreetings.Name = "labelGreetings";
            this.labelGreetings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGreetings.Size = new System.Drawing.Size(192, 24);
            this.labelGreetings.TabIndex = 21;
            this.labelGreetings.Text = "Welcome, jowallet";
            this.labelGreetings.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelGreetings.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // upbarLog
            // 
            this.upbarLog.Controls.Add(this.panel1);
            this.upbarLog.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.upbarLog.Location = new System.Drawing.Point(181, 0);
            this.upbarLog.MaximumSize = new System.Drawing.Size(268, 135);
            this.upbarLog.MinimumSize = new System.Drawing.Size(268, 70);
            this.upbarLog.Name = "upbarLog";
            this.upbarLog.Size = new System.Drawing.Size(268, 70);
            this.upbarLog.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnExpand);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 131);
            this.panel1.TabIndex = 10;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Image = global::bank.Properties.Resources.logoutpink;
            this.btnLogOut.Location = new System.Drawing.Point(85, 71);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(164, 59);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpand.Image = global::bank.Properties.Resources.Expand_Arrow;
            this.btnExpand.Location = new System.Drawing.Point(206, 14);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(43, 50);
            this.btnExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExpand.TabIndex = 9;
            this.btnExpand.TabStop = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timerDropDown
            // 
            this.timerDropDown.Interval = 10;
            this.timerDropDown.Tick += new System.EventHandler(this.timerDropDown_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 624);
            this.Controls.Add(this.gradientPanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditTopUp)).EndInit();
            this.gradientPanelLogin.ResumeLayout(false);
            this.gradientPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.upbarLog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnEditTopUp;
        private Bunifu.UI.WinForms.BunifuGradientPanel gradientPanelLogin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.FlowLayoutPanel upbarLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExpand;
        private System.Windows.Forms.PictureBox btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerDropDown;
        private Bunifu.UI.WinForms.BunifuLabel labelGreetings;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuLabel labelDate;
        private System.Windows.Forms.Timer timer;
        private Bunifu.UI.WinForms.BunifuLabel lbltop;
        private Bunifu.UI.WinForms.BunifuLabel lblcust;
        private System.Windows.Forms.PictureBox btnEditCustomer;
    }
}