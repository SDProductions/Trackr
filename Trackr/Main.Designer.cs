namespace Trackr
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ClientTitle = new System.Windows.Forms.Label();
            this.StartInputActivity = new System.Windows.Forms.Button();
            this.InputActivity = new System.Windows.Forms.TextBox();
            this.ClientDayLabel = new System.Windows.Forms.Label();
            this.activtyTimer = new System.Windows.Forms.Timer(this.components);
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.ClientIcon = new System.Windows.Forms.PictureBox();
            this.ClientControlBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientControlBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientTitle
            // 
            this.ClientTitle.AutoSize = true;
            this.ClientTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientTitle.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientTitle.ForeColor = System.Drawing.Color.Silver;
            this.ClientTitle.Location = new System.Drawing.Point(34, 6);
            this.ClientTitle.Name = "ClientTitle";
            this.ClientTitle.Size = new System.Drawing.Size(88, 18);
            this.ClientTitle.TabIndex = 3;
            this.ClientTitle.Text = "Trackr Client";
            // 
            // StartInputActivity
            // 
            this.StartInputActivity.BackColor = System.Drawing.Color.Cornsilk;
            this.StartInputActivity.FlatAppearance.BorderSize = 0;
            this.StartInputActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartInputActivity.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartInputActivity.Location = new System.Drawing.Point(260, 40);
            this.StartInputActivity.Name = "StartInputActivity";
            this.StartInputActivity.Size = new System.Drawing.Size(90, 30);
            this.StartInputActivity.TabIndex = 6;
            this.StartInputActivity.Text = "Start";
            this.StartInputActivity.UseVisualStyleBackColor = false;
            this.StartInputActivity.Click += new System.EventHandler(this.StartInputActivity_Click);
            // 
            // InputActivity
            // 
            this.InputActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.InputActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputActivity.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputActivity.ForeColor = System.Drawing.Color.Silver;
            this.InputActivity.Location = new System.Drawing.Point(16, 47);
            this.InputActivity.Name = "InputActivity";
            this.InputActivity.Size = new System.Drawing.Size(230, 16);
            this.InputActivity.TabIndex = 7;
            this.InputActivity.Text = "What are you doing?";
            this.InputActivity.Click += new System.EventHandler(this.InputActivity_Click);
            // 
            // ClientDayLabel
            // 
            this.ClientDayLabel.AutoSize = true;
            this.ClientDayLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientDayLabel.Location = new System.Drawing.Point(12, 83);
            this.ClientDayLabel.Name = "ClientDayLabel";
            this.ClientDayLabel.Size = new System.Drawing.Size(51, 22);
            this.ClientDayLabel.TabIndex = 9;
            this.ClientDayLabel.Text = "Today";
            // 
            // activtyTimer
            // 
            this.activtyTimer.Interval = 1000;
            this.activtyTimer.Tick += new System.EventHandler(this.activtyTimer_Tick);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.Minimize.Image = global::Trackr.Properties.Resources.minimize;
            this.Minimize.Location = new System.Drawing.Point(290, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(26, 26);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 5;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // Maximize
            // 
            this.Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.Maximize.Image = global::Trackr.Properties.Resources.close;
            this.Maximize.Location = new System.Drawing.Point(320, 2);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(26, 26);
            this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximize.TabIndex = 4;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            this.Maximize.MouseEnter += new System.EventHandler(this.Maximize_MouseEnter);
            this.Maximize.MouseLeave += new System.EventHandler(this.Maximize_MouseLeave);
            // 
            // ClientIcon
            // 
            this.ClientIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientIcon.Image = ((System.Drawing.Image)(resources.GetObject("ClientIcon.Image")));
            this.ClientIcon.Location = new System.Drawing.Point(2, 2);
            this.ClientIcon.Name = "ClientIcon";
            this.ClientIcon.Size = new System.Drawing.Size(26, 26);
            this.ClientIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClientIcon.TabIndex = 2;
            this.ClientIcon.TabStop = false;
            // 
            // ClientControlBar
            // 
            this.ClientControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientControlBar.Location = new System.Drawing.Point(0, 0);
            this.ClientControlBar.Name = "ClientControlBar";
            this.ClientControlBar.Size = new System.Drawing.Size(350, 80);
            this.ClientControlBar.TabIndex = 0;
            this.ClientControlBar.TabStop = false;
            this.ClientControlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientControlBar_MouseMove);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.ClientDayLabel);
            this.Controls.Add(this.InputActivity);
            this.Controls.Add(this.StartInputActivity);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Maximize);
            this.Controls.Add(this.ClientTitle);
            this.Controls.Add(this.ClientIcon);
            this.Controls.Add(this.ClientControlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Trackr";
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientControlBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ClientControlBar;
        private System.Windows.Forms.PictureBox ClientIcon;
        private System.Windows.Forms.Label ClientTitle;
        private System.Windows.Forms.PictureBox Maximize;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Button StartInputActivity;
        private System.Windows.Forms.TextBox InputActivity;
        private System.Windows.Forms.Label ClientDayLabel;
        private System.Windows.Forms.Timer activtyTimer;
    }
}

