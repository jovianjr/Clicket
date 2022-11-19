namespace Clicket
{
    partial class MovieItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAgeRate = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pb_poster = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.btn_Details = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAgeRate
            // 
            this.lbAgeRate.AutoSize = true;
            this.lbAgeRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.lbAgeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAgeRate.ForeColor = System.Drawing.Color.White;
            this.lbAgeRate.Location = new System.Drawing.Point(32, 473);
            this.lbAgeRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgeRate.Name = "lbAgeRate";
            this.lbAgeRate.Size = new System.Drawing.Size(27, 25);
            this.lbAgeRate.TabIndex = 21;
            this.lbAgeRate.Text = "R";
            this.lbAgeRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(24, 526);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(114, 25);
            this.lbTitle.TabIndex = 19;
            this.lbTitle.Text = "Barbarian";
            // 
            // pb_poster
            // 
            this.pb_poster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_poster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_poster.ErrorImage = null;
            this.pb_poster.Location = new System.Drawing.Point(24, 30);
            this.pb_poster.Margin = new System.Windows.Forms.Padding(2);
            this.pb_poster.Name = "pb_poster";
            this.pb_poster.Size = new System.Drawing.Size(328, 484);
            this.pb_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_poster.TabIndex = 18;
            this.pb_poster.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbLocation);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbGenre);
            this.panel1.Controls.Add(this.btn_Details);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 706);
            this.panel1.TabIndex = 20;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLocation.Location = new System.Drawing.Point(18, 599);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(94, 25);
            this.lbLocation.TabIndex = 15;
            this.lbLocation.Text = "Location";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(18, 573);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(57, 25);
            this.lbDate.TabIndex = 14;
            this.lbDate.Text = "Date";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGenre.Location = new System.Drawing.Point(18, 547);
            this.lbGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(71, 25);
            this.lbGenre.TabIndex = 13;
            this.lbGenre.Text = "Genre";
            // 
            // btn_Details
            // 
            this.btn_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Details.ForeColor = System.Drawing.Color.White;
            this.btn_Details.Location = new System.Drawing.Point(254, 649);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(91, 39);
            this.btn_Details.TabIndex = 12;
            this.btn_Details.Text = "Details >";
            this.btn_Details.UseVisualStyleBackColor = false;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.White;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPrice.Location = new System.Drawing.Point(17, 653);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(111, 25);
            this.lbPrice.TabIndex = 10;
            this.lbPrice.Text = "Rp 25.000";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDur
            // 
            this.lbDur.AutoSize = true;
            this.lbDur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lbDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDur.Location = new System.Drawing.Point(276, 479);
            this.lbDur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDur.Name = "lbDur";
            this.lbDur.Size = new System.Drawing.Size(62, 20);
            this.lbDur.TabIndex = 22;
            this.lbDur.Text = "1h 40m";
            // 
            // MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbDur);
            this.Controls.Add(this.lbAgeRate);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pb_poster);
            this.Controls.Add(this.panel1);
            this.Name = "MovieItem";
            this.Size = new System.Drawing.Size(374, 718);
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbAgeRate;
        private Label lbTitle;
        private PictureBox pb_poster;
        private Panel panel1;
        private Label lbLocation;
        private Label lbDate;
        private Label lbGenre;
        private Button btn_Details;
        private Label lbPrice;
        private Label lbDur;
    }
}
