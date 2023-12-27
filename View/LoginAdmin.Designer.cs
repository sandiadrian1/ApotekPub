namespace ApotekPub.View
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.labelJudul = new System.Windows.Forms.Label();
            this.panelJudul = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBoxShow = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBoxHide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPw = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPw = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelCopyRight = new System.Windows.Forms.Label();
            this.labelDesk = new System.Windows.Forms.Label();
            this.btnBackLogHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelJudul.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Californian FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.SystemColors.Control;
            this.labelJudul.Location = new System.Drawing.Point(189, 19);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(346, 33);
            this.labelJudul.TabIndex = 8;
            this.labelJudul.Text = "PROJECT MANUFAKTUR";
            // 
            // panelJudul
            // 
            this.panelJudul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelJudul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelJudul.Controls.Add(this.labelJudul);
            this.panelJudul.Location = new System.Drawing.Point(0, 56);
            this.panelJudul.Name = "panelJudul";
            this.panelJudul.Size = new System.Drawing.Size(623, 73);
            this.panelJudul.TabIndex = 9;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelLogin.Controls.Add(this.pictureBoxShow);
            this.panelLogin.Controls.Add(this.pictureBoxHide);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.textBoxId);
            this.panelLogin.Controls.Add(this.textBoxPw);
            this.panelLogin.Controls.Add(this.labelPw);
            this.panelLogin.Controls.Add(this.labelId);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Location = new System.Drawing.Point(111, 166);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(361, 306);
            this.panelLogin.TabIndex = 0;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxShow.BorderRadius = 5;
            this.pictureBoxShow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShow.Image")));
            this.pictureBoxShow.ImageRotate = 0F;
            this.pictureBoxShow.Location = new System.Drawing.Point(238, 180);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(33, 19);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 12;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxShow_Click_1);
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxHide.BorderRadius = 5;
            this.pictureBoxHide.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHide.Image")));
            this.pictureBoxHide.ImageRotate = 0F;
            this.pictureBoxHide.Location = new System.Drawing.Point(238, 180);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(33, 19);
            this.pictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHide.TabIndex = 11;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.Click += new System.EventHandler(this.pictureBoxHide_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(83, 239);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.BorderColor = System.Drawing.Color.Black;
            this.textBoxId.BorderRadius = 7;
            this.textBoxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxId.DefaultText = "";
            this.textBoxId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxId.Location = new System.Drawing.Point(77, 94);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PasswordChar = '\0';
            this.textBoxId.PlaceholderText = "input password";
            this.textBoxId.SelectedText = "";
            this.textBoxId.Size = new System.Drawing.Size(200, 23);
            this.textBoxId.TabIndex = 8;
            // 
            // textBoxPw
            // 
            this.textBoxPw.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPw.BorderRadius = 7;
            this.textBoxPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPw.DefaultText = "";
            this.textBoxPw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPw.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPw.Location = new System.Drawing.Point(77, 178);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.PasswordChar = '\0';
            this.textBoxPw.PlaceholderText = "input password";
            this.textBoxPw.SelectedText = "";
            this.textBoxPw.Size = new System.Drawing.Size(200, 23);
            this.textBoxPw.TabIndex = 7;
            // 
            // labelPw
            // 
            this.labelPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPw.AutoSize = true;
            this.labelPw.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F);
            this.labelPw.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPw.Location = new System.Drawing.Point(79, 155);
            this.labelPw.Name = "labelPw";
            this.labelPw.Size = new System.Drawing.Size(91, 20);
            this.labelPw.TabIndex = 6;
            this.labelPw.Text = "PASSWORD  :";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Adobe Devanagari", 11.25F);
            this.labelId.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelId.Location = new System.Drawing.Point(79, 71);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(91, 20);
            this.labelId.TabIndex = 5;
            this.labelId.Text = "USERNAME  :";
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Castellar", 20.25F);
            this.labelLogin.ForeColor = System.Drawing.Color.Lime;
            this.labelLogin.Location = new System.Drawing.Point(126, 16);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(111, 33);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "LOGIN";
            // 
            // labelCopyRight
            // 
            this.labelCopyRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyRight.AutoSize = true;
            this.labelCopyRight.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyRight.Location = new System.Drawing.Point(217, 497);
            this.labelCopyRight.Name = "labelCopyRight";
            this.labelCopyRight.Size = new System.Drawing.Size(402, 17);
            this.labelCopyRight.TabIndex = 10;
            this.labelCopyRight.Text = "@ 2023  Pharmacy PUB  ,   All Right Reserved |  By Sandi Adrian";
            // 
            // labelDesk
            // 
            this.labelDesk.AutoSize = true;
            this.labelDesk.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesk.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDesk.Location = new System.Drawing.Point(12, 12);
            this.labelDesk.Name = "labelDesk";
            this.labelDesk.Size = new System.Drawing.Size(142, 26);
            this.labelDesk.TabIndex = 11;
            this.labelDesk.Text = "Buy Here Guys";
            // 
            // btnBackLogHome
            // 
            this.btnBackLogHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackLogHome.BorderRadius = 7;
            this.btnBackLogHome.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnBackLogHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackLogHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackLogHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackLogHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackLogHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBackLogHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackLogHome.ForeColor = System.Drawing.Color.Black;
            this.btnBackLogHome.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnBackLogHome.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnBackLogHome.Location = new System.Drawing.Point(12, 478);
            this.btnBackLogHome.Name = "btnBackLogHome";
            this.btnBackLogHome.Size = new System.Drawing.Size(83, 36);
            this.btnBackLogHome.TabIndex = 12;
            this.btnBackLogHome.Text = "Back";
            this.btnBackLogHome.Click += new System.EventHandler(this.btnBackLogHome_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(551, 10);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(37, 22);
            this.btnMax.TabIndex = 14;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(515, 11);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 21);
            this.btnMin.TabIndex = 13;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(590, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 25);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(623, 521);
            this.Controls.Add(this.btnBackLogHome);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelDesk);
            this.Controls.Add(this.labelCopyRight);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAdmin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.LoginAdmin_Load);
            this.panelJudul.ResumeLayout(false);
            this.panelJudul.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Panel panelJudul;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPw;
        private System.Windows.Forms.Label labelCopyRight;
        private System.Windows.Forms.Label labelDesk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPw;
        private Guna.UI2.WinForms.Guna2TextBox textBoxId;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxHide;
        private Guna.UI2.WinForms.Guna2Button btnBackLogHome;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxShow;
    }
}