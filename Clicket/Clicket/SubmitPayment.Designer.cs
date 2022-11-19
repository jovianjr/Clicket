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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbFile = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.Title.SuspendLayout();
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
            this.btn_back.Location = new System.Drawing.Point(61, 31);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 42);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = false;
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
            this.lbInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInstruction.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInstruction.ForeColor = System.Drawing.Color.Black;
            this.lbInstruction.Location = new System.Drawing.Point(134, 144);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(344, 28);
            this.lbInstruction.TabIndex = 6;
            this.lbInstruction.Text = "Finish your transaction with total:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFile.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFile.ForeColor = System.Drawing.Color.Black;
            this.lbFile.Location = new System.Drawing.Point(134, 245);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(384, 28);
            this.lbFile.TabIndex = 11;
            this.lbFile.Text = "Please submit your payment slip here";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Font = new System.Drawing.Font("Rubik", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(134, 181);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(51, 36);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "Rp";
            // 
            // SubmitPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1424, 697);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.lbInstruction);
            this.Controls.Add(this.Title);
            this.Name = "SubmitPayment";
            this.Text = "SubmitPayment";
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Title;
        private Button btn_back;
        private Label lb_title;
        private Panel panel4;
        private Label lbInstruction;
        private OpenFileDialog openFileDialog1;
        private Label lbFile;
        private Label lbTotal;
    }
}