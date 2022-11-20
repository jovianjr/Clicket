namespace Clicket
{
    partial class SubmitPayment
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
            this.Title = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.ofdPayment = new System.Windows.Forms.OpenFileDialog();
            this.lbFile = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lbFileName = new System.Windows.Forms.Label();
            this.pbIllustration = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnSubmitSlip = new System.Windows.Forms.Panel();
            this.pnThanks = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIllustration)).BeginInit();
            this.pnSubmitSlip.SuspendLayout();
            this.pnThanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.Title.TabIndex = 10;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.lb_title.Size = new System.Drawing.Size(279, 42);
            this.lb_title.TabIndex = 4;
            this.lb_title.Text = "Submit Payment";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(754, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 94);
            this.panel4.TabIndex = 3;
            // 
            // lbInstruction
            // 
            this.lbInstruction.AutoSize = true;
            this.lbInstruction.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInstruction.ForeColor = System.Drawing.Color.Black;
            this.lbInstruction.Location = new System.Drawing.Point(13, 14);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(342, 26);
            this.lbInstruction.TabIndex = 6;
            this.lbInstruction.Text = "Finish your transaction with total:";
            // 
            // ofdPayment
            // 
            this.ofdPayment.FileName = "openFileDialog1";
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFile.ForeColor = System.Drawing.Color.Black;
            this.lbFile.Location = new System.Drawing.Point(13, 115);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(382, 26);
            this.lbFile.TabIndex = 11;
            this.lbFile.Text = "Please submit your payment slip here";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Rubik", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(13, 51);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(49, 34);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "Rp";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(548, 110);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(133, 37);
            this.btnOpenFile.TabIndex = 13;
            this.btnOpenFile.Text = "Browse";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFileName.ForeColor = System.Drawing.Color.Black;
            this.lbFileName.Location = new System.Drawing.Point(13, 159);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(13, 20);
            this.lbFileName.TabIndex = 14;
            this.lbFileName.Text = " ";
            // 
            // pbIllustration
            // 
            this.pbIllustration.Image = global::Clicket.Properties.Resources.Pay_Illustration;
            this.pbIllustration.Location = new System.Drawing.Point(753, 0);
            this.pbIllustration.Name = "pbIllustration";
            this.pbIllustration.Size = new System.Drawing.Size(598, 395);
            this.pbIllustration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIllustration.TabIndex = 15;
            this.pbIllustration.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(548, 239);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 37);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnSubmitSlip
            // 
            this.pnSubmitSlip.Controls.Add(this.pbIllustration);
            this.pnSubmitSlip.Controls.Add(this.btnSubmit);
            this.pnSubmitSlip.Controls.Add(this.btnOpenFile);
            this.pnSubmitSlip.Controls.Add(this.lbInstruction);
            this.pnSubmitSlip.Controls.Add(this.lbFileName);
            this.pnSubmitSlip.Controls.Add(this.lbFile);
            this.pnSubmitSlip.Controls.Add(this.lbTotal);
            this.pnSubmitSlip.Location = new System.Drawing.Point(61, 131);
            this.pnSubmitSlip.Name = "pnSubmitSlip";
            this.pnSubmitSlip.Size = new System.Drawing.Size(1351, 402);
            this.pnSubmitSlip.TabIndex = 17;
            // 
            // pnThanks
            // 
            this.pnThanks.Controls.Add(this.label1);
            this.pnThanks.Controls.Add(this.pictureBox1);
            this.pnThanks.Controls.Add(this.label4);
            this.pnThanks.Location = new System.Drawing.Point(61, 124);
            this.pnThanks.Name = "pnThanks";
            this.pnThanks.Size = new System.Drawing.Size(1351, 402);
            this.pnThanks.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(115, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your transaction will be processed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clicket.Properties.Resources.Processed_illustration;
            this.pictureBox1.Location = new System.Drawing.Point(731, -62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(210, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thank you for submitting";
            // 
            // SubmitPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 558);
            this.Controls.Add(this.pnThanks);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pnSubmitSlip);
            this.Name = "SubmitPayment";
            this.Text = "SubmitPayment";
            this.Load += new System.EventHandler(this.SubmitPayment_Load);
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIllustration)).EndInit();
            this.pnSubmitSlip.ResumeLayout(false);
            this.pnSubmitSlip.PerformLayout();
            this.pnThanks.ResumeLayout(false);
            this.pnThanks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Title;
        private Button btn_back;
        private Label lb_title;
        private Panel panel4;
        private Label lbInstruction;
        private OpenFileDialog ofdPayment;
        private Label lbFile;
        private Label lbTotal;
        private Button btnOpenFile;
        private Label lbFileName;
        private PictureBox pbIllustration;
        private Button btnSubmit;
        private Panel pnSubmitSlip;
        private Panel pnThanks;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}