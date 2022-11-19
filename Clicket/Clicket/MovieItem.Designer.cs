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
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btn_Details = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAgeRate
            // 
            this.lbAgeRate.AutoSize = true;
            this.lbAgeRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.lbAgeRate.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAgeRate.ForeColor = System.Drawing.Color.White;
            this.lbAgeRate.Location = new System.Drawing.Point(32, 473);
            this.lbAgeRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgeRate.Name = "lbAgeRate";
            this.lbAgeRate.Size = new System.Drawing.Size(26, 26);
            this.lbAgeRate.TabIndex = 21;
            this.lbAgeRate.Text = "R";
            this.lbAgeRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(24, 526);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(116, 26);
            this.lbTitle.TabIndex = 19;
            this.lbTitle.Text = "Barbarian";
            // 
            // pb_poster
            // 
            this.pb_poster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_poster.ErrorImage = null;
            this.pb_poster.Location = new System.Drawing.Point(24, 30);
            this.pb_poster.Margin = new System.Windows.Forms.Padding(2);
            this.pb_poster.Name = "pb_poster";
            this.pb_poster.Size = new System.Drawing.Size(328, 484);
            this.pb_poster.TabIndex = 18;
            this.pb_poster.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Controls.Add(this.btn_Details);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 706);
            this.panel1.TabIndex = 20;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(18, 599);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(98, 26);
            this.lblLocation.TabIndex = 15;
            this.lblLocation.Text = "Location";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(18, 573);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 26);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(18, 547);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(71, 26);
            this.lblGenre.TabIndex = 13;
            this.lblGenre.Text = "Genre";
            // 
            // btn_Details
            // 
            this.btn_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Details.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Details.ForeColor = System.Drawing.Color.White;
            this.btn_Details.Location = new System.Drawing.Point(254, 649);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(91, 39);
            this.btn_Details.TabIndex = 12;
            this.btn_Details.Text = "Details >";
            this.btn_Details.UseVisualStyleBackColor = false;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(17, 653);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(112, 26);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Rp 25.000";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDur
            // 
            this.lblDur.AutoSize = true;
            this.lblDur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.lblDur.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDur.Location = new System.Drawing.Point(276, 479);
            this.lblDur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDur.Name = "lblDur";
            this.lblDur.Size = new System.Drawing.Size(64, 20);
            this.lblDur.TabIndex = 22;
            this.lblDur.Text = "1h 40m";
            // 
            // MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDur);
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
        private Label lblLocation;
        private Label lblDate;
        private Label lblGenre;
        private Button btn_Details;
        private Label lblPrice;
        private Label lblDur;
    }
}
