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
            this.lbTitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbQuota = new System.Windows.Forms.Label();
            this.pn_Details = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbDur = new System.Windows.Forms.Label();
            this.lbAgeRate = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.pb_poster = new System.Windows.Forms.PictureBox();
            this.pn_payment = new System.Windows.Forms.Panel();
            this.btn_minQty = new System.Windows.Forms.Button();
            this.lbTitleInPay = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbLocationInPay = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lbPriceInPay = new System.Windows.Forms.Label();
            this.lbDateInPay = new System.Windows.Forms.Label();
            this.lb_qty_chosen = new System.Windows.Forms.Label();
            this.btn_addQty = new System.Windows.Forms.Button();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.lb_qty = new System.Windows.Forms.Label();
            this.Title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pn_Details.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).BeginInit();
            this.pn_payment.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(17, 24);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(114, 25);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Barbarian";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.Title.Controls.Add(this.btn_back);
            this.Title.Controls.Add(this.lb_title);
            this.Title.Controls.Add(this.panel4);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1424, 94);
            this.Title.TabIndex = 9;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(61, 31);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 42);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(124, 31);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(84, 39);
            this.lb_title.TabIndex = 4;
            this.lb_title.Text = "Title";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1424, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 94);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 603);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbQuota);
            this.panel3.Controls.Add(this.pn_Details);
            this.panel3.Controls.Add(this.pb_poster);
            this.panel3.Controls.Add(this.pn_payment);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel3.Size = new System.Drawing.Size(1424, 603);
            this.panel3.TabIndex = 27;
            // 
            // lbQuota
            // 
            this.lbQuota.AutoSize = true;
            this.lbQuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbQuota.Location = new System.Drawing.Point(1131, 107);
            this.lbQuota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuota.Name = "lbQuota";
            this.lbQuota.Size = new System.Drawing.Size(174, 25);
            this.lbQuota.TabIndex = 26;
            this.lbQuota.Text = "_ seats available";
            this.lbQuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pn_Details
            // 
            this.pn_Details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Details.Controls.Add(this.tbDescription);
            this.pn_Details.Controls.Add(this.lbLocation);
            this.pn_Details.Controls.Add(this.panel2);
            this.pn_Details.Controls.Add(this.lbDate);
            this.pn_Details.Controls.Add(this.lblPrice);
            this.pn_Details.Controls.Add(this.btn_buy);
            this.pn_Details.Controls.Add(this.lbTitle);
            this.pn_Details.Location = new System.Drawing.Point(434, 53);
            this.pn_Details.Name = "pn_Details";
            this.pn_Details.Size = new System.Drawing.Size(886, 309);
            this.pn_Details.TabIndex = 9;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescription.Location = new System.Drawing.Point(17, 125);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(698, 171);
            this.tbDescription.TabIndex = 32;
            this.tbDescription.Text = "Description";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLocation.Location = new System.Drawing.Point(17, 77);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(94, 25);
            this.lbLocation.TabIndex = 30;
            this.lbLocation.Text = "Location";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbGenre);
            this.panel2.Controls.Add(this.lbDur);
            this.panel2.Controls.Add(this.lbAgeRate);
            this.panel2.Location = new System.Drawing.Point(290, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 32);
            this.panel2.TabIndex = 29;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGenre.Location = new System.Drawing.Point(301, 0);
            this.lbGenre.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbGenre.Size = new System.Drawing.Size(91, 25);
            this.lbGenre.TabIndex = 24;
            this.lbGenre.Text = "Genre";
            this.lbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDur
            // 
            this.lbDur.AutoSize = true;
            this.lbDur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lbDur.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDur.Location = new System.Drawing.Point(392, 0);
            this.lbDur.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbDur.Name = "lbDur";
            this.lbDur.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbDur.Size = new System.Drawing.Size(103, 25);
            this.lbDur.TabIndex = 28;
            this.lbDur.Text = "1h 40m";
            // 
            // lbAgeRate
            // 
            this.lbAgeRate.AutoSize = true;
            this.lbAgeRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.lbAgeRate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbAgeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAgeRate.ForeColor = System.Drawing.Color.White;
            this.lbAgeRate.Location = new System.Drawing.Point(495, 0);
            this.lbAgeRate.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbAgeRate.Name = "lbAgeRate";
            this.lbAgeRate.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbAgeRate.Size = new System.Drawing.Size(93, 25);
            this.lbAgeRate.TabIndex = 27;
            this.lbAgeRate.Text = "PG-13";
            this.lbAgeRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(17, 51);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(57, 25);
            this.lbDate.TabIndex = 25;
            this.lbDate.Text = "Date";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(766, 226);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(111, 25);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Rp 25.000";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.Location = new System.Drawing.Point(736, 258);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(142, 38);
            this.btn_buy.TabIndex = 9;
            this.btn_buy.Text = "Buy Ticket";
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // pb_poster
            // 
            this.pb_poster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_poster.ErrorImage = null;
            this.pb_poster.Location = new System.Drawing.Point(52, 53);
            this.pb_poster.Margin = new System.Windows.Forms.Padding(2);
            this.pb_poster.Name = "pb_poster";
            this.pb_poster.Size = new System.Drawing.Size(362, 532);
            this.pb_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_poster.TabIndex = 11;
            this.pb_poster.TabStop = false;
            // 
            // pn_payment
            // 
            this.pn_payment.Controls.Add(this.btn_minQty);
            this.pn_payment.Controls.Add(this.lbTitleInPay);
            this.pn_payment.Controls.Add(this.panel5);
            this.pn_payment.Controls.Add(this.btn_addQty);
            this.pn_payment.Controls.Add(this.tb_qty);
            this.pn_payment.Controls.Add(this.lb_qty);
            this.pn_payment.Location = new System.Drawing.Point(28, 24);
            this.pn_payment.Name = "pn_payment";
            this.pn_payment.Size = new System.Drawing.Size(1328, 567);
            this.pn_payment.TabIndex = 10;
            // 
            // btn_minQty
            // 
            this.btn_minQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_minQty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_minQty.ForeColor = System.Drawing.Color.White;
            this.btn_minQty.Location = new System.Drawing.Point(426, 103);
            this.btn_minQty.Name = "btn_minQty";
            this.btn_minQty.Size = new System.Drawing.Size(46, 32);
            this.btn_minQty.TabIndex = 32;
            this.btn_minQty.Text = "-";
            this.btn_minQty.UseVisualStyleBackColor = false;
            this.btn_minQty.Click += new System.EventHandler(this.btn_minQty_Click);
            // 
            // lbTitleInPay
            // 
            this.lbTitleInPay.AutoSize = true;
            this.lbTitleInPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitleInPay.Location = new System.Drawing.Point(421, 28);
            this.lbTitleInPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitleInPay.Name = "lbTitleInPay";
            this.lbTitleInPay.Size = new System.Drawing.Size(114, 25);
            this.lbTitleInPay.TabIndex = 31;
            this.lbTitleInPay.Text = "Barbarian";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lbLocationInPay);
            this.panel5.Controls.Add(this.btnPay);
            this.panel5.Controls.Add(this.lbPriceInPay);
            this.panel5.Controls.Add(this.lbDateInPay);
            this.panel5.Controls.Add(this.lb_qty_chosen);
            this.panel5.Location = new System.Drawing.Point(406, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(886, 172);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbTotal);
            this.panel6.Location = new System.Drawing.Point(666, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(212, 35);
            this.panel6.TabIndex = 37;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(136, 0);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(76, 33);
            this.lbTotal.TabIndex = 16;
            this.lbTotal.Text = "Rp 0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLocationInPay
            // 
            this.lbLocationInPay.AutoSize = true;
            this.lbLocationInPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLocationInPay.Location = new System.Drawing.Point(19, 40);
            this.lbLocationInPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocationInPay.Name = "lbLocationInPay";
            this.lbLocationInPay.Size = new System.Drawing.Size(94, 25);
            this.lbLocationInPay.TabIndex = 36;
            this.lbLocationInPay.Text = "Location";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPay.Location = new System.Drawing.Point(766, 120);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(106, 34);
            this.btnPay.TabIndex = 25;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbPriceInPay
            // 
            this.lbPriceInPay.AutoSize = true;
            this.lbPriceInPay.BackColor = System.Drawing.Color.White;
            this.lbPriceInPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPriceInPay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPriceInPay.Location = new System.Drawing.Point(19, 77);
            this.lbPriceInPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPriceInPay.Name = "lbPriceInPay";
            this.lbPriceInPay.Size = new System.Drawing.Size(111, 25);
            this.lbPriceInPay.TabIndex = 32;
            this.lbPriceInPay.Text = "Rp 25.000";
            this.lbPriceInPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDateInPay
            // 
            this.lbDateInPay.AutoSize = true;
            this.lbDateInPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDateInPay.Location = new System.Drawing.Point(19, 14);
            this.lbDateInPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateInPay.Name = "lbDateInPay";
            this.lbDateInPay.Size = new System.Drawing.Size(57, 25);
            this.lbDateInPay.TabIndex = 33;
            this.lbDateInPay.Text = "Date";
            // 
            // lb_qty_chosen
            // 
            this.lb_qty_chosen.AutoSize = true;
            this.lb_qty_chosen.BackColor = System.Drawing.Color.Transparent;
            this.lb_qty_chosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_qty_chosen.Location = new System.Drawing.Point(256, 77);
            this.lb_qty_chosen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_qty_chosen.Name = "lb_qty_chosen";
            this.lb_qty_chosen.Size = new System.Drawing.Size(35, 25);
            this.lb_qty_chosen.TabIndex = 26;
            this.lb_qty_chosen.Text = "x1";
            // 
            // btn_addQty
            // 
            this.btn_addQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_addQty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addQty.ForeColor = System.Drawing.Color.White;
            this.btn_addQty.Location = new System.Drawing.Point(586, 103);
            this.btn_addQty.Name = "btn_addQty";
            this.btn_addQty.Size = new System.Drawing.Size(53, 32);
            this.btn_addQty.TabIndex = 22;
            this.btn_addQty.Text = "+";
            this.btn_addQty.UseVisualStyleBackColor = false;
            this.btn_addQty.Click += new System.EventHandler(this.btn_addQty_Click);
            // 
            // tb_qty
            // 
            this.tb_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_qty.Location = new System.Drawing.Point(478, 103);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(102, 31);
            this.tb_qty.TabIndex = 21;
            // 
            // lb_qty
            // 
            this.lb_qty.AutoSize = true;
            this.lb_qty.BackColor = System.Drawing.Color.Transparent;
            this.lb_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_qty.Location = new System.Drawing.Point(421, 63);
            this.lb_qty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_qty.Name = "lb_qty";
            this.lb_qty.Size = new System.Drawing.Size(98, 25);
            this.lb_qty.TabIndex = 20;
            this.lb_qty.Text = "Quantity:";
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1424, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.Name = "Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Detail_Load);
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pn_Details.ResumeLayout(false);
            this.pn_Details.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).EndInit();
            this.pn_payment.ResumeLayout(false);
            this.pn_payment.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbTitle;
        private Panel Title;
        private Button btn_back;
        private Label lb_title;
        private Panel panel4;
        private Panel panel1;
        private Panel pn_Details;
        private Button btn_buy;
        private Panel pn_payment;
        private Panel panel5;
        private Button btnPay;
        private Label lb_qty_chosen;
        private Label lbTotal;
        private Button btn_addQty;
        private TextBox tb_qty;
        private Label lb_qty;
        private Panel panel2;
        private Label lbGenre;
        private Label lbDur;
        private Label lbAgeRate;
        private Label lbQuota;
        private Label lbDate;
        private Label lblPrice;
        private Label lbLocation;
        private TextBox tbDescription;
        private Label lbTitleInPay;
        private Panel panel6;
        private Label lbLocationInPay;
        private Label lbPriceInPay;
        private Label lbDateInPay;
        private PictureBox pb_poster;
        private Button btn_minQty;
        private Panel panel3;
    }
}