namespace Clicket
{
    partial class EventItem
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.pb_poster = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btn_Details = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(25, 528);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(69, 25);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Judul";
            // 
            // pb_poster
            // 
            this.pb_poster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_poster.ErrorImage = null;
            this.pb_poster.Location = new System.Drawing.Point(24, 30);
            this.pb_poster.Margin = new System.Windows.Forms.Padding(2);
            this.pb_poster.Name = "pb_poster";
            this.pb_poster.Size = new System.Drawing.Size(328, 484);
            this.pb_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_poster.TabIndex = 7;
            this.pb_poster.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(17, 617);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(111, 25);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Rp 25.000";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Details
            // 
            this.btn_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Details.ForeColor = System.Drawing.Color.White;
            this.btn_Details.Location = new System.Drawing.Point(254, 613);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(91, 39);
            this.btn_Details.TabIndex = 12;
            this.btn_Details.Text = "Details >";
            this.btn_Details.UseVisualStyleBackColor = false;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(17, 547);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(17, 573);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(94, 25);
            this.lblLocation.TabIndex = 15;
            this.lblLocation.Text = "Location";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.btn_Details);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 674);
            this.panel1.TabIndex = 13;
            // 
            // EventItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pb_poster);
            this.Controls.Add(this.panel1);
            this.Name = "EventItem";
            this.Size = new System.Drawing.Size(374, 685);
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbTitle;
        private PictureBox pb_poster;
        private Label lblPrice;
        private Button btn_Details;
        private Label lblDate;
        private Label lblLocation;
        private Panel panel1;
    }
}
