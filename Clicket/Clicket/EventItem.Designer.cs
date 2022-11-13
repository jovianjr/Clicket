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
            this.btn_Details = new System.Windows.Forms.Button();
            this.lbAgeRate = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pb_poster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Details
            // 
            this.btn_Details.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Details.Location = new System.Drawing.Point(266, 601);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(75, 32);
            this.btn_Details.TabIndex = 10;
            this.btn_Details.Text = "Details";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // lbAgeRate
            // 
            this.lbAgeRate.AutoSize = true;
            this.lbAgeRate.BackColor = System.Drawing.Color.Cornsilk;
            this.lbAgeRate.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAgeRate.Location = new System.Drawing.Point(25, 554);
            this.lbAgeRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgeRate.Name = "lbAgeRate";
            this.lbAgeRate.Size = new System.Drawing.Size(26, 26);
            this.lbAgeRate.TabIndex = 9;
            this.lbAgeRate.Text = "R";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(25, 528);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(116, 26);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Barbarian";
            // 
            // pb_poster
            // 
            this.pb_poster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_poster.ErrorImage = null;
            this.pb_poster.Location = new System.Drawing.Point(25, 29);
            this.pb_poster.Margin = new System.Windows.Forms.Padding(2);
            this.pb_poster.Name = "pb_poster";
            this.pb_poster.Size = new System.Drawing.Size(316, 484);
            this.pb_poster.TabIndex = 7;
            this.pb_poster.TabStop = false;
            // 
            // EventItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.lbAgeRate);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pb_poster);
            this.Name = "EventItem";
            this.Size = new System.Drawing.Size(367, 662);
            ((System.ComponentModel.ISupportInitialize)(this.pb_poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Details;
        private Label lbAgeRate;
        private Label lbTitle;
        private PictureBox pb_poster;
    }
}
