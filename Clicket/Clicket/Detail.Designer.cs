namespace Clicket
{
    partial class Detail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAgeRate = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pb_poster = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_payment = new System.Windows.Forms.Panel();
            this.lb_time = new System.Windows.Forms.Label();
            this.btn_redeem = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.lb_qty_chosen = new System.Windows.Forms.Label();
            this.lb_time_chosen = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lb_cinema_chosen = new System.Windows.Forms.Label();
            this.btn_addQty = new System.Windows.Forms.Button();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.lb_qty = new System.Windows.Forms.Label();
            this.tb_voucher = new System.Windows.Forms.TextBox();
            this.cb_time = new System.Windows.Forms.ComboBox();
            this.lb_cinema = new System.Windows.Forms.Label();
            this.cb_cinema = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_Details = new System.Windows.Forms.Panel();
            this.btn_buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).BeginInit();
            this.Title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_payment.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAgeRate
            // 
            this.lbAgeRate.AutoSize = true;
            this.lbAgeRate.BackColor = System.Drawing.Color.Cornsilk;
            this.lbAgeRate.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAgeRate.Location = new System.Drawing.Point(17, 50);
            this.lbAgeRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgeRate.Name = "lbAgeRate";
            this.lbAgeRate.Size = new System.Drawing.Size(26, 26);
            this.lbAgeRate.TabIndex = 8;
            this.lbAgeRate.Text = "R";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(17, 24);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(116, 26);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Barbarian";
            // 
            // pb_poster
            // 
            this.pb_poster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_poster.ErrorImage = null;
            this.pb_poster.Location = new System.Drawing.Point(61, 32);
            this.pb_poster.Margin = new System.Windows.Forms.Padding(2);
            this.pb_poster.Name = "pb_poster";
            this.pb_poster.Size = new System.Drawing.Size(386, 602);
            this.pb_poster.TabIndex = 6;
            this.pb_poster.TabStop = false;
            // 
            // Title
            // 
            this.Title.Controls.Add(this.btn_back);
            this.Title.Controls.Add(this.lb_title);
            this.Title.Controls.Add(this.panel4);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1424, 100);
            this.Title.TabIndex = 9;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(61, 31);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 42);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_title.Font = new System.Drawing.Font("Rubik SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.Location = new System.Drawing.Point(124, 31);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(90, 42);
            this.lb_title.TabIndex = 4;
            this.lb_title.Text = "Title";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(754, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 100);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pn_payment);
            this.panel1.Controls.Add(this.pb_poster);
            this.panel1.Controls.Add(this.pn_Details);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 661);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pn_payment
            // 
            this.pn_payment.Controls.Add(this.lb_time);
            this.pn_payment.Controls.Add(this.btn_redeem);
            this.pn_payment.Controls.Add(this.panel5);
            this.pn_payment.Controls.Add(this.btn_addQty);
            this.pn_payment.Controls.Add(this.tb_qty);
            this.pn_payment.Controls.Add(this.lb_qty);
            this.pn_payment.Controls.Add(this.tb_voucher);
            this.pn_payment.Controls.Add(this.cb_time);
            this.pn_payment.Controls.Add(this.lb_cinema);
            this.pn_payment.Controls.Add(this.cb_cinema);
            this.pn_payment.Controls.Add(this.pictureBox1);
            this.pn_payment.Controls.Add(this.label2);
            this.pn_payment.Controls.Add(this.label3);
            this.pn_payment.Location = new System.Drawing.Point(61, 32);
            this.pn_payment.Name = "pn_payment";
            this.pn_payment.Size = new System.Drawing.Size(1295, 602);
            this.pn_payment.TabIndex = 10;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.BackColor = System.Drawing.Color.Transparent;
            this.lb_time.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_time.Location = new System.Drawing.Point(201, 351);
            this.lb_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(131, 26);
            this.lb_time.TabIndex = 25;
            this.lb_time.Text = "Select Time:";
            // 
            // btn_redeem
            // 
            this.btn_redeem.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_redeem.Location = new System.Drawing.Point(520, 546);
            this.btn_redeem.Name = "btn_redeem";
            this.btn_redeem.Size = new System.Drawing.Size(106, 32);
            this.btn_redeem.TabIndex = 24;
            this.btn_redeem.Text = "Redeem";
            this.btn_redeem.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPay);
            this.panel5.Controls.Add(this.lb_qty_chosen);
            this.panel5.Controls.Add(this.lb_time_chosen);
            this.panel5.Controls.Add(this.lbPrice);
            this.panel5.Controls.Add(this.lb_cinema_chosen);
            this.panel5.Location = new System.Drawing.Point(693, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(543, 228);
            this.panel5.TabIndex = 23;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(424, 169);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(106, 32);
            this.btnPay.TabIndex = 25;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // lb_qty_chosen
            // 
            this.lb_qty_chosen.AutoSize = true;
            this.lb_qty_chosen.BackColor = System.Drawing.Color.Transparent;
            this.lb_qty_chosen.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_qty_chosen.Location = new System.Drawing.Point(19, 77);
            this.lb_qty_chosen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_qty_chosen.Name = "lb_qty_chosen";
            this.lb_qty_chosen.Size = new System.Drawing.Size(32, 26);
            this.lb_qty_chosen.TabIndex = 26;
            this.lb_qty_chosen.Text = "x1";
            // 
            // lb_time_chosen
            // 
            this.lb_time_chosen.AutoSize = true;
            this.lb_time_chosen.BackColor = System.Drawing.Color.Transparent;
            this.lb_time_chosen.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_time_chosen.Location = new System.Drawing.Point(19, 45);
            this.lb_time_chosen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_time_chosen.Name = "lb_time_chosen";
            this.lb_time_chosen.Size = new System.Drawing.Size(257, 26);
            this.lb_time_chosen.TabIndex = 25;
            this.lb_time_chosen.Text = "27 Nov 2022 | 9.00 - 11.35";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Rubik", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(19, 127);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(76, 36);
            this.lbPrice.TabIndex = 16;
            this.lbPrice.Text = "Rp 0";
            // 
            // lb_cinema_chosen
            // 
            this.lb_cinema_chosen.AutoSize = true;
            this.lb_cinema_chosen.BackColor = System.Drawing.Color.Transparent;
            this.lb_cinema_chosen.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cinema_chosen.Location = new System.Drawing.Point(19, 13);
            this.lb_cinema_chosen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinema_chosen.Name = "lb_cinema_chosen";
            this.lb_cinema_chosen.Size = new System.Drawing.Size(83, 26);
            this.lb_cinema_chosen.TabIndex = 24;
            this.lb_cinema_chosen.Text = "XXI Teti";
            // 
            // btn_addQty
            // 
            this.btn_addQty.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addQty.Location = new System.Drawing.Point(309, 473);
            this.btn_addQty.Name = "btn_addQty";
            this.btn_addQty.Size = new System.Drawing.Size(106, 32);
            this.btn_addQty.TabIndex = 22;
            this.btn_addQty.Text = "+";
            this.btn_addQty.UseVisualStyleBackColor = true;
            this.btn_addQty.Click += new System.EventHandler(this.btn_addQty_Click);
            // 
            // tb_qty
            // 
            this.tb_qty.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_qty.Location = new System.Drawing.Point(201, 473);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(102, 32);
            this.tb_qty.TabIndex = 21;
            // 
            // lb_qty
            // 
            this.lb_qty.AutoSize = true;
            this.lb_qty.BackColor = System.Drawing.Color.Transparent;
            this.lb_qty.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_qty.Location = new System.Drawing.Point(201, 433);
            this.lb_qty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_qty.Name = "lb_qty";
            this.lb_qty.Size = new System.Drawing.Size(102, 26);
            this.lb_qty.TabIndex = 20;
            this.lb_qty.Text = "Quantity:";
            // 
            // tb_voucher
            // 
            this.tb_voucher.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_voucher.Location = new System.Drawing.Point(201, 546);
            this.tb_voucher.Name = "tb_voucher";
            this.tb_voucher.Size = new System.Drawing.Size(313, 32);
            this.tb_voucher.TabIndex = 18;
            // 
            // cb_time
            // 
            this.cb_time.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_time.FormattingEnabled = true;
            this.cb_time.Location = new System.Drawing.Point(201, 380);
            this.cb_time.Name = "cb_time";
            this.cb_time.Size = new System.Drawing.Size(425, 34);
            this.cb_time.TabIndex = 13;
            // 
            // lb_cinema
            // 
            this.lb_cinema.AutoSize = true;
            this.lb_cinema.BackColor = System.Drawing.Color.Transparent;
            this.lb_cinema.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cinema.Location = new System.Drawing.Point(201, 264);
            this.lb_cinema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cinema.Name = "lb_cinema";
            this.lb_cinema.Size = new System.Drawing.Size(159, 26);
            this.lb_cinema.TabIndex = 12;
            this.lb_cinema.Text = "Select Cinema:";
            // 
            // cb_cinema
            // 
            this.cb_cinema.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_cinema.FormattingEnabled = true;
            this.cb_cinema.Location = new System.Drawing.Point(201, 293);
            this.cb_cinema.Name = "cb_cinema";
            this.cb_cinema.Size = new System.Drawing.Size(425, 34);
            this.cb_cinema.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(24, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 221);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(201, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(201, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Barbarian";
            // 
            // pn_Details
            // 
            this.pn_Details.Controls.Add(this.btn_buy);
            this.pn_Details.Controls.Add(this.lbAgeRate);
            this.pn_Details.Controls.Add(this.lbTitle);
            this.pn_Details.Location = new System.Drawing.Point(459, 373);
            this.pn_Details.Name = "pn_Details";
            this.pn_Details.Size = new System.Drawing.Size(897, 261);
            this.pn_Details.TabIndex = 9;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(17, 205);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(129, 38);
            this.btn_buy.TabIndex = 9;
            this.btn_buy.Text = "Buy Ticket";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.Name = "Detail";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).EndInit();
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pn_payment.ResumeLayout(false);
            this.pn_payment.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_Details.ResumeLayout(false);
            this.pn_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbAgeRate;
        private Label lbTitle;
        private PictureBox pb_poster;
        private Panel Title;
        private Button btn_back;
        private Label lb_title;
        private Panel panel4;
        private Panel panel1;
        private Panel pn_Details;
        private Button btn_buy;
        private Panel pn_payment;
        private ComboBox cb_time;
        private Label lb_cinema;
        private ComboBox cb_cinema;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button btn_redeem;
        private Panel panel5;
        private Button btnPay;
        private Label lb_qty_chosen;
        private Label lb_time_chosen;
        private Label lbPrice;
        private Label lb_cinema_chosen;
        private Button btn_addQty;
        private TextBox tb_qty;
        private Label lb_qty;
        private TextBox tb_voucher;
        private Label lb_time;
    }
}