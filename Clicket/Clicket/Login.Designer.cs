namespace Clicket
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.linkLupaPassword = new System.Windows.Forms.LinkLabel();
            this.lblBelumPunyaAkun = new System.Windows.Forms.Label();
            this.lblBuatAkun = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkTermOfUse = new System.Windows.Forms.LinkLabel();
            this.linkFAQ = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(101, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 94);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clicket";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(101, 255);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(170, 45);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(101, 303);
            this.tbUsername.MaximumSize = new System.Drawing.Size(413, 34);
            this.tbUsername.MinimumSize = new System.Drawing.Size(413, 34);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(413, 34);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(101, 395);
            this.tbPassword.MaximumSize = new System.Drawing.Size(413, 34);
            this.tbPassword.MinimumSize = new System.Drawing.Size(413, 34);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(413, 34);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(101, 347);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(160, 45);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // linkLupaPassword
            // 
            this.linkLupaPassword.AutoSize = true;
            this.linkLupaPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLupaPassword.LinkColor = System.Drawing.Color.Black;
            this.linkLupaPassword.Location = new System.Drawing.Point(347, 444);
            this.linkLupaPassword.Name = "linkLupaPassword";
            this.linkLupaPassword.Size = new System.Drawing.Size(167, 30);
            this.linkLupaPassword.TabIndex = 5;
            this.linkLupaPassword.TabStop = true;
            this.linkLupaPassword.Text = "Lupa password?";
            this.linkLupaPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLupaPassword_LinkClicked);
            // 
            // lblBelumPunyaAkun
            // 
            this.lblBelumPunyaAkun.AutoSize = true;
            this.lblBelumPunyaAkun.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBelumPunyaAkun.Location = new System.Drawing.Point(155, 603);
            this.lblBelumPunyaAkun.Name = "lblBelumPunyaAkun";
            this.lblBelumPunyaAkun.Size = new System.Drawing.Size(201, 30);
            this.lblBelumPunyaAkun.TabIndex = 6;
            this.lblBelumPunyaAkun.Text = "Belum punya akun?";
            // 
            // lblBuatAkun
            // 
            this.lblBuatAkun.AutoSize = true;
            this.lblBuatAkun.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuatAkun.LinkColor = System.Drawing.Color.Black;
            this.lblBuatAkun.Location = new System.Drawing.Point(356, 603);
            this.lblBuatAkun.Name = "lblBuatAkun";
            this.lblBuatAkun.Size = new System.Drawing.Size(117, 30);
            this.lblBuatAkun.TabIndex = 7;
            this.lblBuatAkun.TabStop = true;
            this.lblBuatAkun.Text = "Buat akun";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(176, 528);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(64, 4, 64, 4);
            this.btnLogin.Size = new System.Drawing.Size(274, 63);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Location = new System.Drawing.Point(801, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(555, 555);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // linkTermOfUse
            // 
            this.linkTermOfUse.AutoSize = true;
            this.linkTermOfUse.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkTermOfUse.LinkColor = System.Drawing.Color.Black;
            this.linkTermOfUse.Location = new System.Drawing.Point(961, 652);
            this.linkTermOfUse.Name = "linkTermOfUse";
            this.linkTermOfUse.Size = new System.Drawing.Size(134, 30);
            this.linkTermOfUse.TabIndex = 10;
            this.linkTermOfUse.TabStop = true;
            this.linkTermOfUse.Text = "Term Of Use";
            // 
            // linkFAQ
            // 
            this.linkFAQ.AutoSize = true;
            this.linkFAQ.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkFAQ.LinkColor = System.Drawing.Color.Black;
            this.linkFAQ.Location = new System.Drawing.Point(1139, 652);
            this.linkFAQ.Name = "linkFAQ";
            this.linkFAQ.Size = new System.Drawing.Size(54, 30);
            this.linkFAQ.TabIndex = 11;
            this.linkFAQ.TabStop = true;
            this.linkFAQ.Text = "FAQ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 761);
            this.Controls.Add(this.linkFAQ);
            this.Controls.Add(this.linkTermOfUse);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblBuatAkun);
            this.Controls.Add(this.lblBelumPunyaAkun);
            this.Controls.Add(this.linkLupaPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label lblBrand;
        private PictureBox pictureBox2;
        private Label lblUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lblPassword;
        private LinkLabel linkLupaPassword;
        private Label lblBelumPunyaAkun;
        private LinkLabel lblBuatAkun;
        private Button btnLogin;
        private Panel panel3;
        private LinkLabel linkTermOfUse;
        private LinkLabel linkFAQ;
    }
}