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
            this.ProjectColor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ActivityName = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.Label();
            this.ActivityTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectColor
            // 
            this.ProjectColor.BackColor = System.Drawing.Color.SteelBlue;
            this.ProjectColor.Location = new System.Drawing.Point(0, 0);
            this.ProjectColor.Name = "ProjectColor";
            this.ProjectColor.Size = new System.Drawing.Size(350, 10);
            this.ProjectColor.TabIndex = 0;
            this.ProjectColor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 2);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ActivityName
            // 
            this.ActivityName.AutoSize = true;
            this.ActivityName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityName.Location = new System.Drawing.Point(3, 13);
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.Size = new System.Drawing.Size(90, 18);
            this.ActivityName.TabIndex = 2;
            this.ActivityName.Text = "Activity Name";
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.Location = new System.Drawing.Point(3, 35);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(79, 16);
            this.ProjectName.TabIndex = 3;
            this.ProjectName.Text = "Project Name";
            // 
            // ActivtyTime
            // 
            this.ActivityTime.AutoSize = true;
            this.ActivityTime.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityTime.Location = new System.Drawing.Point(200, 25);
            this.ActivityTime.Name = "ActivtyTime";
            this.ActivityTime.Size = new System.Drawing.Size(109, 21);
            this.ActivityTime.TabIndex = 4;
            this.ActivityTime.Text = "00:00:00s";
            // 
            // ActivityPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.ActivityTime);
            this.Controls.Add(this.ProjectName);
            this.Controls.Add(this.ActivityName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProjectColor);
            this.Name = "ActivityPanel";
            this.Size = new System.Drawing.Size(350, 60);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox ProjectColor;
        internal System.Windows.Forms.Label ActivityName;
        internal System.Windows.Forms.Label ProjectName;
        internal System.Windows.Forms.Label ActivityTime;
    }
}
