namespace Trackr.Controls
{
    partial class HSVSlider
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
            this.SelectorHueBackground = new System.Windows.Forms.Panel();
            this.SelectorHue = new System.Windows.Forms.Panel();
            this.SelectorSaturationBackground = new System.Windows.Forms.Panel();
            this.SaturationValueBackground = new System.Windows.Forms.Panel();
            this.SelectorSaturationValue = new System.Windows.Forms.Panel();
            this.SaturationValue = new System.Windows.Forms.Panel();
            this.CurrentColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SelectorHueBackground
            // 
            this.SelectorHueBackground.Location = new System.Drawing.Point(5, 15);
            this.SelectorHueBackground.Name = "SelectorHueBackground";
            this.SelectorHueBackground.Size = new System.Drawing.Size(240, 20);
            this.SelectorHueBackground.TabIndex = 0;
            this.SelectorHueBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectorHueBackground_Paint);
            // 
            // SelectorHue
            // 
            this.SelectorHue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SelectorHue.Location = new System.Drawing.Point(5, 10);
            this.SelectorHue.Name = "SelectorHue";
            this.SelectorHue.Size = new System.Drawing.Size(6, 30);
            this.SelectorHue.TabIndex = 2;
            // 
            // SelectorSaturationBackground
            // 
            this.SelectorSaturationBackground.Location = new System.Drawing.Point(270, 10);
            this.SelectorSaturationBackground.Name = "SelectorSaturationBackground";
            this.SelectorSaturationBackground.Size = new System.Drawing.Size(20, 30);
            this.SelectorSaturationBackground.TabIndex = 3;
            // 
            // SaturationValueBackground
            // 
            this.SaturationValueBackground.Location = new System.Drawing.Point(320, 10);
            this.SaturationValueBackground.Name = "SaturationValueBackground";
            this.SaturationValueBackground.Size = new System.Drawing.Size(20, 30);
            this.SaturationValueBackground.TabIndex = 4;
            // 
            // SelectorSaturationValue
            // 
            this.SelectorSaturationValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SelectorSaturationValue.Location = new System.Drawing.Point(265, 10);
            this.SelectorSaturationValue.Name = "SelectorSaturationValue";
            this.SelectorSaturationValue.Size = new System.Drawing.Size(30, 6);
            this.SelectorSaturationValue.TabIndex = 3;
            // 
            // SaturationValue
            // 
            this.SaturationValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaturationValue.Location = new System.Drawing.Point(315, 10);
            this.SaturationValue.Name = "SaturationValue";
            this.SaturationValue.Size = new System.Drawing.Size(30, 6);
            this.SaturationValue.TabIndex = 4;
            // 
            // CurrentColor
            // 
            this.CurrentColor.Location = new System.Drawing.Point(362, 15);
            this.CurrentColor.Name = "CurrentColor";
            this.CurrentColor.Size = new System.Drawing.Size(20, 20);
            this.CurrentColor.TabIndex = 5;
            // 
            // HSVSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CurrentColor);
            this.Controls.Add(this.SaturationValue);
            this.Controls.Add(this.SelectorSaturationValue);
            this.Controls.Add(this.SaturationValueBackground);
            this.Controls.Add(this.SelectorSaturationBackground);
            this.Controls.Add(this.SelectorHue);
            this.Controls.Add(this.SelectorHueBackground);
            this.Name = "HSVSlider";
            this.Size = new System.Drawing.Size(400, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SelectorHueBackground;
        private System.Windows.Forms.Panel SelectorHue;
        private System.Windows.Forms.Panel SelectorSaturationBackground;
        private System.Windows.Forms.Panel SaturationValueBackground;
        private System.Windows.Forms.Panel SelectorSaturationValue;
        private System.Windows.Forms.Panel SaturationValue;
        private System.Windows.Forms.Panel CurrentColor;
    }
}
