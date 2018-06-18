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
            this.ClientTitle = new System.Windows.Forms.Label();
            this.StartInputActivity = new System.Windows.Forms.Button();
            this.InputActivity = new System.Windows.Forms.TextBox();
            this.ClientDayLabel = new System.Windows.Forms.Label();
            this.ActivtyTimer = new System.Windows.Forms.Timer(this.components);
            this.ActivitiesDisplay = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.ClientIcon = new System.Windows.Forms.PictureBox();
            this.ClientControlBar = new System.Windows.Forms.PictureBox();
            this.EditorPanel = new System.Windows.Forms.Panel();
            this.CloseEditor = new System.Windows.Forms.Button();
            this.EditorActivityTitleLabel = new System.Windows.Forms.Label();
            this.EditorActivityTitle = new System.Windows.Forms.TextBox();
            this.EditorTitle = new System.Windows.Forms.Label();
            this.ProjectColorSideBar = new System.Windows.Forms.PictureBox();
            this.EditorControlBar = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditorSplitter = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientControlBar)).BeginInit();
            this.EditorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectColorSideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorControlBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // ActivtyTimer
            // 
            this.ActivtyTimer.Interval = 1000;
            this.ActivtyTimer.Tick += new System.EventHandler(this.ActivtyTimer_Tick);
            // 
            // ActivitiesDisplay
            // 
            this.ActivitiesDisplay.AutoScroll = true;
            this.ActivitiesDisplay.BackColor = System.Drawing.Color.FloralWhite;
            this.ActivitiesDisplay.Location = new System.Drawing.Point(0, 110);
            this.ActivitiesDisplay.Name = "ActivitiesDisplay";
            this.ActivitiesDisplay.Size = new System.Drawing.Size(350, 360);
            this.ActivitiesDisplay.TabIndex = 10;
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
            this.ClientIcon.Image = global::Trackr.Properties.Resources.home;
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
            // EditorPanel
            // 
            this.EditorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.EditorPanel.Controls.Add(this.comboBox1);
            this.EditorPanel.Controls.Add(this.pictureBox1);
            this.EditorPanel.Controls.Add(this.label2);
            this.EditorPanel.Controls.Add(this.textBox2);
            this.EditorPanel.Controls.Add(this.EditorSplitter);
            this.EditorPanel.Controls.Add(this.label1);
            this.EditorPanel.Controls.Add(this.textBox1);
            this.EditorPanel.Controls.Add(this.CloseEditor);
            this.EditorPanel.Controls.Add(this.EditorActivityTitleLabel);
            this.EditorPanel.Controls.Add(this.EditorActivityTitle);
            this.EditorPanel.Controls.Add(this.EditorTitle);
            this.EditorPanel.Controls.Add(this.ProjectColorSideBar);
            this.EditorPanel.Controls.Add(this.EditorControlBar);
            this.EditorPanel.Location = new System.Drawing.Point(350, 0);
            this.EditorPanel.Name = "EditorPanel";
            this.EditorPanel.Size = new System.Drawing.Size(400, 500);
            this.EditorPanel.TabIndex = 12;
            // 
            // CloseEditor
            // 
            this.CloseEditor.BackColor = System.Drawing.Color.Cornsilk;
            this.CloseEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseEditor.Location = new System.Drawing.Point(372, 2);
            this.CloseEditor.Name = "CloseEditor";
            this.CloseEditor.Size = new System.Drawing.Size(25, 25);
            this.CloseEditor.TabIndex = 4;
            this.CloseEditor.Text = "<";
            this.CloseEditor.UseVisualStyleBackColor = false;
            this.CloseEditor.Click += new System.EventHandler(this.CloseEditor_Click);
            // 
            // EditorActivityTitleLabel
            // 
            this.EditorActivityTitleLabel.AutoSize = true;
            this.EditorActivityTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.EditorActivityTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorActivityTitleLabel.ForeColor = System.Drawing.Color.Silver;
            this.EditorActivityTitleLabel.Location = new System.Drawing.Point(17, 30);
            this.EditorActivityTitleLabel.Name = "EditorActivityTitleLabel";
            this.EditorActivityTitleLabel.Size = new System.Drawing.Size(73, 16);
            this.EditorActivityTitleLabel.TabIndex = 3;
            this.EditorActivityTitleLabel.Text = "Activity Title";
            // 
            // EditorActivityTitle
            // 
            this.EditorActivityTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.EditorActivityTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditorActivityTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditorActivityTitle.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorActivityTitle.ForeColor = System.Drawing.Color.Silver;
            this.EditorActivityTitle.Location = new System.Drawing.Point(20, 46);
            this.EditorActivityTitle.Name = "EditorActivityTitle";
            this.EditorActivityTitle.Size = new System.Drawing.Size(377, 23);
            this.EditorActivityTitle.TabIndex = 2;
            this.EditorActivityTitle.TextChanged += new System.EventHandler(this.EditorActivityTitle_TextChanged);
            // 
            // EditorTitle
            // 
            this.EditorTitle.AutoSize = true;
            this.EditorTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.EditorTitle.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorTitle.ForeColor = System.Drawing.Color.Silver;
            this.EditorTitle.Location = new System.Drawing.Point(17, 6);
            this.EditorTitle.Name = "EditorTitle";
            this.EditorTitle.Size = new System.Drawing.Size(191, 18);
            this.EditorTitle.TabIndex = 1;
            this.EditorTitle.Text = "Extended Activity Information";
            // 
            // ProjectColorSideBar
            // 
            this.ProjectColorSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProjectColorSideBar.Location = new System.Drawing.Point(0, 0);
            this.ProjectColorSideBar.Name = "ProjectColorSideBar";
            this.ProjectColorSideBar.Size = new System.Drawing.Size(10, 500);
            this.ProjectColorSideBar.TabIndex = 0;
            this.ProjectColorSideBar.TabStop = false;
            // 
            // EditorControlBar
            // 
            this.EditorControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.EditorControlBar.Location = new System.Drawing.Point(10, 0);
            this.EditorControlBar.Name = "EditorControlBar";
            this.EditorControlBar.Size = new System.Drawing.Size(390, 80);
            this.EditorControlBar.TabIndex = 13;
            this.EditorControlBar.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(91, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 25);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "12:00AM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Time";
            // 
            // EditorSplitter
            // 
            this.EditorSplitter.BackColor = System.Drawing.Color.Silver;
            this.EditorSplitter.Location = new System.Drawing.Point(10, 105);
            this.EditorSplitter.Name = "EditorSplitter";
            this.EditorSplitter.Size = new System.Drawing.Size(390, 1);
            this.EditorSplitter.TabIndex = 16;
            this.EditorSplitter.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(232, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 25);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "12:00PM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Project";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(10, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 1);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.EditorPanel);
            this.Controls.Add(this.ActivitiesDisplay);
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
            this.EditorPanel.ResumeLayout(false);
            this.EditorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectColorSideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorControlBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Timer ActivtyTimer;
        internal System.Windows.Forms.Panel ActivitiesDisplay;
        private System.Windows.Forms.Panel EditorPanel;
        private System.Windows.Forms.PictureBox ProjectColorSideBar;
        private System.Windows.Forms.Label EditorTitle;
        private System.Windows.Forms.Label EditorActivityTitleLabel;
        private System.Windows.Forms.Button CloseEditor;
        private System.Windows.Forms.PictureBox EditorControlBar;
        private System.Windows.Forms.TextBox EditorActivityTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox EditorSplitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

