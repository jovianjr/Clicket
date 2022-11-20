namespace Clicket
{
    partial class CreateUpdate
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
            this.pn_payment = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbAgeRate = new System.Windows.Forms.ComboBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.tbQuota = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbDurMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDurHour = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbAgeRate = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbDur = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbQuota = new System.Windows.Forms.Label();
            this.pb_poster = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Panel();
            this.ofdPoster = new System.Windows.Forms.OpenFileDialog();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.pn_payment.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).BeginInit();
            this.Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pn_payment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 623);
            this.panel1.TabIndex = 12;
            // 
            // pn_payment
            // 
            this.pn_payment.Controls.Add(this.btnChange);
            this.pn_payment.Controls.Add(this.panel5);
            this.pn_payment.Controls.Add(this.pb_poster);
            this.pn_payment.Location = new System.Drawing.Point(12, 20);
            this.pn_payment.Name = "pn_payment";
            this.pn_payment.Size = new System.Drawing.Size(1301, 567);
            this.pn_payment.TabIndex = 10;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChange.Location = new System.Drawing.Point(242, 520);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(134, 34);
            this.btnChange.TabIndex = 55;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dtpEndDate);
            this.panel5.Controls.Add(this.cbAgeRate);
            this.panel5.Controls.Add(this.cbGenre);
            this.panel5.Controls.Add(this.tbQuota);
            this.panel5.Controls.Add(this.tbPrice);
            this.panel5.Controls.Add(this.tbDescription);
            this.panel5.Controls.Add(this.lbDescription);
            this.panel5.Controls.Add(this.tbDurMin);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.tbDurHour);
            this.panel5.Controls.Add(this.tbLocation);
            this.panel5.Controls.Add(this.dtpDate);
            this.panel5.Controls.Add(this.tbTitle);
            this.panel5.Controls.Add(this.lbAgeRate);
            this.panel5.Controls.Add(this.lbGenre);
            this.panel5.Controls.Add(this.lbDur);
            this.panel5.Controls.Add(this.lbTitle);
            this.panel5.Controls.Add(this.lbLocation);
            this.panel5.Controls.Add(this.btnConfirm);
            this.panel5.Controls.Add(this.lbPrice);
            this.panel5.Controls.Add(this.lbDate);
            this.panel5.Controls.Add(this.lbQuota);
            this.panel5.Location = new System.Drawing.Point(400, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(892, 532);
            this.panel5.TabIndex = 23;
            // 
            // cbAgeRate
            // 
            this.cbAgeRate.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAgeRate.FormattingEnabled = true;
            this.cbAgeRate.Items.AddRange(new object[] {
            "NR",
            "R",
            "PG-13",
            "PG",
            "G"});
            this.cbAgeRate.Location = new System.Drawing.Point(242, 427);
            this.cbAgeRate.Name = "cbAgeRate";
            this.cbAgeRate.Size = new System.Drawing.Size(186, 32);
            this.cbAgeRate.TabIndex = 54;
            // 
            // cbGenre
            // 
            this.cbGenre.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(242, 389);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(186, 32);
            this.cbGenre.TabIndex = 53;
            // 
            // tbQuota
            // 
            this.tbQuota.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQuota.Location = new System.Drawing.Point(242, 353);
            this.tbQuota.Name = "tbQuota";
            this.tbQuota.Size = new System.Drawing.Size(186, 30);
            this.tbQuota.TabIndex = 52;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPrice.Location = new System.Drawing.Point(243, 281);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(622, 30);
            this.tbPrice.TabIndex = 51;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescription.Location = new System.Drawing.Point(243, 134);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(622, 141);
            this.tbDescription.TabIndex = 50;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescription.Location = new System.Drawing.Point(22, 138);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(125, 26);
            this.lbDescription.TabIndex = 49;
            this.lbDescription.Text = "Description";
            // 
            // tbDurMin
            // 
            this.tbDurMin.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDurMin.Location = new System.Drawing.Point(428, 317);
            this.tbDurMin.Name = "tbDurMin";
            this.tbDurMin.Size = new System.Drawing.Size(78, 30);
            this.tbDurMin.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(511, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 47;
            this.label2.Text = "minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(326, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 46;
            this.label1.Text = "hour";
            // 
            // tbDurHour
            // 
            this.tbDurHour.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDurHour.Location = new System.Drawing.Point(243, 317);
            this.tbDurHour.Name = "tbDurHour";
            this.tbDurHour.Size = new System.Drawing.Size(78, 30);
            this.tbDurHour.TabIndex = 44;
            // 
            // tbLocation
            // 
            this.tbLocation.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLocation.Location = new System.Drawing.Point(243, 98);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(622, 30);
            this.tbLocation.TabIndex = 43;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(243, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(278, 30);
            this.dtpDate.TabIndex = 42;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTitle.Location = new System.Drawing.Point(243, 26);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(622, 30);
            this.tbTitle.TabIndex = 40;
            // 
            // lbAgeRate
            // 
            this.lbAgeRate.AutoSize = true;
            this.lbAgeRate.BackColor = System.Drawing.Color.Transparent;
            this.lbAgeRate.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAgeRate.Location = new System.Drawing.Point(23, 433);
            this.lbAgeRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgeRate.Name = "lbAgeRate";
            this.lbAgeRate.Size = new System.Drawing.Size(97, 26);
            this.lbAgeRate.TabIndex = 39;
            this.lbAgeRate.Text = "AgeRate";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.BackColor = System.Drawing.Color.Transparent;
            this.lbGenre.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGenre.Location = new System.Drawing.Point(23, 395);
            this.lbGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(71, 26);
            this.lbGenre.TabIndex = 38;
            this.lbGenre.Text = "Genre";
            // 
            // lbDur
            // 
            this.lbDur.AutoSize = true;
            this.lbDur.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDur.Location = new System.Drawing.Point(23, 317);
            this.lbDur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDur.Name = "lbDur";
            this.lbDur.Size = new System.Drawing.Size(97, 26);
            this.lbDur.TabIndex = 37;
            this.lbDur.Text = "Duration";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(22, 30);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(54, 26);
            this.lbTitle.TabIndex = 31;
            this.lbTitle.Text = "Title";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLocation.Location = new System.Drawing.Point(22, 102);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(98, 26);
            this.lbLocation.TabIndex = 36;
            this.lbLocation.Text = "Location";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(731, 490);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 34);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.White;
            this.lbPrice.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPrice.Location = new System.Drawing.Point(24, 284);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(62, 26);
            this.lbPrice.TabIndex = 32;
            this.lbPrice.Text = "Price";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(22, 66);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(58, 26);
            this.lbDate.TabIndex = 33;
            this.lbDate.Text = "Date";
            // 
            // lbQuota
            // 
            this.lbQuota.AutoSize = true;
            this.lbQuota.BackColor = System.Drawing.Color.Transparent;
            this.lbQuota.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuota.Location = new System.Drawing.Point(23, 357);
            this.lbQuota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuota.Name = "lbQuota";
            this.lbQuota.Size = new System.Drawing.Size(71, 26);
            this.lbQuota.TabIndex = 26;
            this.lbQuota.Text = "Quota";
            // 
            // pb_poster
            // 
            this.pb_poster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_poster.ErrorImage = null;
            this.pb_poster.Location = new System.Drawing.Point(21, 29);
            this.pb_poster.Margin = new System.Windows.Forms.Padding(2);
            this.pb_poster.Name = "pb_poster";
            this.pb_poster.Size = new System.Drawing.Size(362, 532);
            this.pb_poster.TabIndex = 11;
            this.pb_poster.TabStop = false;
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
            this.lb_title.Font = new System.Drawing.Font("Rubik SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(124, 31);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(177, 42);
            this.lb_title.TabIndex = 4;
            this.lb_title.Text = "Form Title";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1341, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 94);
            this.panel4.TabIndex = 3;
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
            this.Title.Size = new System.Drawing.Size(1341, 94);
            this.Title.TabIndex = 11;
            // 
            // ofdPoster
            // 
            this.ofdPoster.FileName = "openFileDialog1";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(587, 63);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(278, 30);
            this.dtpEndDate.TabIndex = 55;
            // 
            // CreateUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.Name = "CreateUpdate";
            this.Text = "CreateUpdate";
            this.panel1.ResumeLayout(false);
            this.pn_payment.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).EndInit();
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Button btn_back;
        private Label lb_title;
        private Panel panel4;
        private Panel Title;
        private OpenFileDialog ofdPoster;
        private Panel pn_payment;
        private Button btnChange;
        private Panel panel5;
        private ComboBox cbAgeRate;
        private ComboBox cbGenre;
        private TextBox tbQuota;
        private TextBox tbPrice;
        private TextBox tbDescription;
        private Label lbDescription;
        private TextBox tbDurMin;
        private Label label2;
        private Label label1;
        private TextBox tbDurHour;
        private TextBox tbLocation;
        private DateTimePicker dtpDate;
        private TextBox tbTitle;
        private Label lbAgeRate;
        private Label lbGenre;
        private Label lbDur;
        private Label lbTitle;
        private Label lbLocation;
        private Button btnConfirm;
        private Label lbPrice;
        private Label lbDate;
        private Label lbQuota;
        private PictureBox pb_poster;
        private DateTimePicker dtpEndDate;
    }
}