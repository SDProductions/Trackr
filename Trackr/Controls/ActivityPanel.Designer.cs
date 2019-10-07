namespace Trackr
{
    partial class ActivityPanel
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
            this.ActivityName = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.Label();
            this.ActivityTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProjectColor = new System.Windows.Forms.PictureBox();
            this.ExpandActivityInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectColor)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivityName
            // 
            this.ActivityName.AutoSize = true;
            this.ActivityName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityName.Location = new System.Drawing.Point(4, 16);
            this.ActivityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.Size = new System.Drawing.Size(118, 23);
            this.ActivityName.TabIndex = 2;
            this.ActivityName.Text = "Activity Name";
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.Location = new System.Drawing.Point(4, 43);
            this.ProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(100, 20);
            this.ProjectName.TabIndex = 3;
            this.ProjectName.Text = "Project Name";
            // 
            // ActivityTime
            // 
            this.ActivityTime.AutoSize = true;
            this.ActivityTime.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityTime.Location = new System.Drawing.Point(256, 31);
            this.ActivityTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActivityTime.Name = "ActivityTime";
            this.ActivityTime.Size = new System.Drawing.Size(124, 27);
            this.ActivityTime.TabIndex = 4;
            this.ActivityTime.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 2);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ProjectColor
            // 
            this.ProjectColor.BackColor = System.Drawing.Color.SteelBlue;
            this.ProjectColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectColor.Location = new System.Drawing.Point(0, 0);
            this.ProjectColor.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectColor.Name = "ProjectColor";
            this.ProjectColor.Size = new System.Drawing.Size(467, 12);
            this.ProjectColor.TabIndex = 0;
            this.ProjectColor.TabStop = false;
            // 
            // ExpandActivityInfo
            // 
            this.ExpandActivityInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExpandActivityInfo.FlatAppearance.BorderSize = 0;
            this.ExpandActivityInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandActivityInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpandActivityInfo.ForeColor = System.Drawing.Color.Black;
            this.ExpandActivityInfo.Location = new System.Drawing.Point(420, 12);
            this.ExpandActivityInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ExpandActivityInfo.Name = "ExpandActivityInfo";
            this.ExpandActivityInfo.Size = new System.Drawing.Size(47, 62);
            this.ExpandActivityInfo.TabIndex = 5;
            this.ExpandActivityInfo.Text = ">";
            this.ExpandActivityInfo.UseVisualStyleBackColor = true;
            this.ExpandActivityInfo.Click += new System.EventHandler(this.ExpandActivityInfo_Click);
            // 
            // ActivityPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.ExpandActivityInfo);
            this.Controls.Add(this.ActivityTime);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.ActivityName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProjectColor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActivityPanel";
            this.Size = new System.Drawing.Size(467, 74);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox ProjectColor;
        internal System.Windows.Forms.Label ActivityName;
        internal System.Windows.Forms.Label ProjectName;
        internal System.Windows.Forms.Label ActivityTime;
        internal System.Windows.Forms.Button ExpandActivityInfo;
    }
}
