namespace Clicket
{
    partial class Dashboard
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Movie = new System.Windows.Forms.Button();
            this.btn_Event = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbSubTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flp_event = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_movie = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Controls.Add(this.lbTitle);
            this.Title.Controls.Add(this.panel4);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1424, 100);
            this.Title.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitle.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(61, 34);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(141, 42);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "#MOVIE";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Movie);
            this.panel4.Controls.Add(this.btn_Event);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(754, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 100);
            this.panel4.TabIndex = 3;
            // 
            // btn_Movie
            // 
            this.btn_Movie.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Movie.Location = new System.Drawing.Point(488, 0);
            this.btn_Movie.Name = "btn_Movie";
            this.btn_Movie.Size = new System.Drawing.Size(91, 100);
            this.btn_Movie.TabIndex = 2;
            this.btn_Movie.Text = "Movie\r\n";
            this.btn_Movie.UseVisualStyleBackColor = true;
            this.btn_Movie.Click += new System.EventHandler(this.btn_Movie_Click);
            // 
            // btn_Event
            // 
            this.btn_Event.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Event.Location = new System.Drawing.Point(579, 0);
            this.btn_Event.Name = "btn_Event";
            this.btn_Event.Size = new System.Drawing.Size(91, 100);
            this.btn_Event.TabIndex = 1;
            this.btn_Event.Text = "Event\r\n";
            this.btn_Event.UseVisualStyleBackColor = true;
            this.btn_Event.Click += new System.EventHandler(this.btn_Event_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbSubTitle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1424, 100);
            this.panel5.TabIndex = 3;
            // 
            // lbSubTitle
            // 
            this.lbSubTitle.AutoSize = true;
            this.lbSubTitle.Font = new System.Drawing.Font("Rubik", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSubTitle.Location = new System.Drawing.Point(200, 34);
            this.lbSubTitle.Name = "lbSubTitle";
            this.lbSubTitle.Size = new System.Drawing.Size(201, 34);
            this.lbSubTitle.TabIndex = 5;
            this.lbSubTitle.Text = "NOW SHOWING";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.flp_event);
            this.panel1.Controls.Add(this.flp_movie);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 502);
            this.panel1.TabIndex = 4;
            // 
            // flp_event
            // 
            this.flp_event.AutoScroll = true;
            this.flp_event.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flp_event.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_event.Location = new System.Drawing.Point(200, 0);
            this.flp_event.Name = "flp_event";
            this.flp_event.Size = new System.Drawing.Size(1024, 502);
            this.flp_event.TabIndex = 3;
            // 
            // flp_movie
            // 
            this.flp_movie.AutoScroll = true;
            this.flp_movie.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flp_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_movie.Location = new System.Drawing.Point(200, 0);
            this.flp_movie.Name = "flp_movie";
            this.flp_movie.Size = new System.Drawing.Size(1024, 502);
            this.flp_movie.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1224, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 502);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 502);
            this.panel2.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Title);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel Title;
        private Label lbTitle;
        private Panel panel4;
        private Panel panel5;
        private Label lbSubTitle;
        private Panel panel1;
        private Button btn_Movie;
        private Button btn_Event;
        private FlowLayoutPanel flp_movie;
        private Panel panel3;
        private Panel panel2;
        private FlowLayoutPanel flp_event;
    }
}