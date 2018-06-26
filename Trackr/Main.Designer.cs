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
            this.ActivtyTimer = new System.Windows.Forms.Timer(this.components);
            this.ActivitiesDisplay = new System.Windows.Forms.Panel();
            this.EditorPanel = new System.Windows.Forms.Panel();
            this.EditorLabel_HyphenTimeElapsed = new System.Windows.Forms.Label();
            this.EditorLabel_ActivityID = new System.Windows.Forms.Label();
            this.EditorLabel_EndTime = new System.Windows.Forms.Label();
            this.EditorLabel_StartTime = new System.Windows.Forms.Label();
            this.EditorProjectColorRGB_B = new System.Windows.Forms.NumericUpDown();
            this.EditorLabel_ColorB = new System.Windows.Forms.Label();
            this.EditorProjectColorRGB_G = new System.Windows.Forms.NumericUpDown();
            this.EditorLabel_ColorG = new System.Windows.Forms.Label();
            this.EditorProjectColorRGB_R = new System.Windows.Forms.NumericUpDown();
            this.EditorLabel_ColorR = new System.Windows.Forms.Label();
            this.EditorLabel_ProjectColor = new System.Windows.Forms.Label();
            this.EditorActivityID = new System.Windows.Forms.Label();
            this.EditorLabel_ProjectSelector = new System.Windows.Forms.Label();
            this.EditorAddProject = new System.Windows.Forms.Button();
            this.EditorProjectSelector = new System.Windows.Forms.ComboBox();
            this.EditorSplitter2 = new System.Windows.Forms.PictureBox();
            this.EditorHeader_Project = new System.Windows.Forms.Label();
            this.EditorTimeEnd = new System.Windows.Forms.TextBox();
            this.EditorSplitter = new System.Windows.Forms.PictureBox();
            this.EditorHeader_Time = new System.Windows.Forms.Label();
            this.EditorTimeStart = new System.Windows.Forms.TextBox();
            this.CloseEditor = new System.Windows.Forms.Button();
            this.EditorHeader_ActivityTitle = new System.Windows.Forms.Label();
            this.EditorActivityTitle = new System.Windows.Forms.TextBox();
            this.EditorTitle = new System.Windows.Forms.Label();
            this.ProjectColorSideBar = new System.Windows.Forms.PictureBox();
            this.EditorControlBar = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.ClientIcon = new System.Windows.Forms.PictureBox();
            this.ClientControlBar = new System.Windows.Forms.PictureBox();
            this.EditorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditorProjectColorRGB_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorProjectColorRGB_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorProjectColorRGB_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorSplitter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorSplitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectColorSideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorControlBar)).BeginInit();
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
            this.ClientTitle.Location = new System.Drawing.Point(30, 6);
            this.ClientTitle.Name = "ClientTitle";
            this.ClientTitle.Size = new System.Drawing.Size(88, 18);
            this.ClientTitle.TabIndex = 3;
            this.ClientTitle.Text = "Trackr Client";
            // 
            // StartInputActivity
            // 
            this.StartInputActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.StartInputActivity.FlatAppearance.BorderSize = 0;
            this.StartInputActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartInputActivity.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartInputActivity.ForeColor = System.Drawing.Color.LightGray;
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
            this.ClientDayLabel.Size = new System.Drawing.Size(78, 22);
            this.ClientDayLabel.TabIndex = 9;
            this.ClientDayLabel.Text = "Activities";
            // 
            // ActivtyTimer
            // 
            this.ActivtyTimer.Interval = 1000;
            this.ActivtyTimer.Tick += new System.EventHandler(this.ActivtyTimer_Tick);
            // 
            // ActivitiesDisplay
            // 
            this.ActivitiesDisplay.AutoScroll = true;
            this.ActivitiesDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.ActivitiesDisplay.Location = new System.Drawing.Point(0, 110);
            this.ActivitiesDisplay.Name = "ActivitiesDisplay";
            this.ActivitiesDisplay.Size = new System.Drawing.Size(350, 360);
            this.ActivitiesDisplay.TabIndex = 10;
            // 
            // EditorPanel
            // 
            this.EditorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.EditorPanel.Controls.Add(this.EditorLabel_HyphenTimeElapsed);
            this.EditorPanel.Controls.Add(this.EditorLabel_ActivityID);
            this.EditorPanel.Controls.Add(this.EditorLabel_EndTime);
            this.EditorPanel.Controls.Add(this.EditorLabel_StartTime);
            this.EditorPanel.Controls.Add(this.EditorProjectColorRGB_B);
            this.EditorPanel.Controls.Add(this.EditorLabel_ColorB);
            this.EditorPanel.Controls.Add(this.EditorProjectColorRGB_G);
            this.EditorPanel.Controls.Add(this.EditorLabel_ColorG);
            this.EditorPanel.Controls.Add(this.EditorProjectColorRGB_R);
            this.EditorPanel.Controls.Add(this.EditorLabel_ColorR);
            this.EditorPanel.Controls.Add(this.EditorLabel_ProjectColor);
            this.EditorPanel.Controls.Add(this.EditorActivityID);
            this.EditorPanel.Controls.Add(this.EditorLabel_ProjectSelector);
            this.EditorPanel.Controls.Add(this.EditorAddProject);
            this.EditorPanel.Controls.Add(this.EditorProjectSelector);
            this.EditorPanel.Controls.Add(this.EditorSplitter2);
            this.EditorPanel.Controls.Add(this.EditorHeader_Project);
            this.EditorPanel.Controls.Add(this.EditorTimeEnd);
            this.EditorPanel.Controls.Add(this.EditorSplitter);
            this.EditorPanel.Controls.Add(this.EditorHeader_Time);
            this.EditorPanel.Controls.Add(this.EditorTimeStart);
            this.EditorPanel.Controls.Add(this.CloseEditor);
            this.EditorPanel.Controls.Add(this.EditorHeader_ActivityTitle);
            this.EditorPanel.Controls.Add(this.EditorActivityTitle);
            this.EditorPanel.Controls.Add(this.EditorTitle);
            this.EditorPanel.Controls.Add(this.ProjectColorSideBar);
            this.EditorPanel.Controls.Add(this.EditorControlBar);
            this.EditorPanel.Location = new System.Drawing.Point(350, 0);
            this.EditorPanel.Name = "EditorPanel";
            this.EditorPanel.Size = new System.Drawing.Size(400, 500);
            this.EditorPanel.TabIndex = 12;
            // 
            // EditorLabel_HyphenTimeElapsed
            // 
            this.EditorLabel_HyphenTimeElapsed.AutoSize = true;
            this.EditorLabel_HyphenTimeElapsed.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorLabel_HyphenTimeElapsed.Location = new System.Drawing.Point(120, 115);
            this.EditorLabel_HyphenTimeElapsed.Name = "EditorLabel_HyphenTimeElapsed";
            this.EditorLabel_HyphenTimeElapsed.Size = new System.Drawing.Size(16, 22);
            this.EditorLabel_HyphenTimeElapsed.TabIndex = 34;
            this.EditorLabel_HyphenTimeElapsed.Text = "-";
            // 
            // EditorLabel_ActivityID
            // 
            this.EditorLabel_ActivityID.AutoSize = true;
            this.EditorLabel_ActivityID.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorLabel_ActivityID.Location = new System.Drawing.Point(284, 478);
            this.EditorLabel_ActivityID.Name = "EditorLabel_ActivityID";
            this.EditorLabel_ActivityID.Size = new System.Drawing.Size(73, 13);
            this.EditorLabel_ActivityID.TabIndex = 33;
            this.EditorLabel_ActivityID.Text = "ActivityID:";
            // 
            // EditorLabel_EndTime
            // 
            this.EditorLabel_EndTime.AutoSize = true;
            this.EditorLabel_EndTime.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorLabel_EndTime.Location = new System.Drawing.Point(185, 140);
            this.EditorLabel_EndTime.Name = "EditorLabel_EndTime";
            this.EditorLabel_EndTime.Size = new System.Drawing.Size(52, 16);
            this.EditorLabel_EndTime.TabIndex = 32;
            this.EditorLabel_EndTime.Text = "End Time";
            // 
            // EditorLabel_StartTime
            // 
            this.EditorLabel_StartTime.AutoSize = true;
            this.EditorLabel_StartTime.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorLabel_StartTime.Location = new System.Drawing.Point(20, 140);
            this.EditorLabel_StartTime.Name = "EditorLabel_StartTime";
            this.EditorLabel_StartTime.Size = new System.Drawing.Size(60, 16);
            this.EditorLabel_StartTime.TabIndex = 31;
            this.EditorLabel_StartTime.Text = "Start Time";
            // 
            // EditorProjectColorRGB_B
            // 
            this.EditorProjectColorRGB_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditorProjectColorRGB_B.Location = new System.Drawing.Point(281, 289);
            this.EditorProjectColorRGB_B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.EditorProjectColorRGB_B.Name = "EditorProjectColorRGB_B";
            this.EditorProjectColorRGB_B.Size = new System.Drawing.Size(55, 20);
            this.EditorProjectColorRGB_B.TabIndex = 30;
            this.EditorProjectColorRGB_B.ValueChanged += new System.EventHandler(this.EditorProjectColorRGB_UpdateColor);
            // 
            // EditorLabel_ColorB
            // 
            this.EditorLabel_ColorB.AutoSize = true;
            this.EditorLabel_ColorB.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorLabel_ColorB.Location = new System.Drawing.Point(261, 290);
            this.EditorLabel_ColorB.Name = "EditorLabel_ColorB";
            this.EditorLabel_ColorB.Size = new System.Drawing.Size(14, 16);
            this.EditorLabel_ColorB.TabIndex = 29;
            this.EditorLabel_ColorB.Text = "B";
            // 
            // EditorProjectColorRGB_G
            // 
            this.EditorProjectColorRGB_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditorProjectColorRGB_G.Location = new System.Drawing.Point(200, 289);
            this.EditorProjectColorRGB_G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.EditorProjectColorRGB_G.Name = "EditorProjectColorRGB_G";
            this.EditorProjectColorRGB_G.Size = new System.Drawing.Size(55, 20);
            this.EditorProjectColorRGB_G.TabIndex = 28;
            this.EditorProjectColorRGB_G.ValueChanged += new System.EventHandler(this.EditorProjectColorRGB_UpdateColor);
            // 
            // EditorLabel_ColorG
            // 
            this.EditorLabel_ColorG.AutoSize = true;
            this.EditorLabel_ColorG.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorLabel_ColorG.Location = new System.Drawing.Point(180, 290);
            this.EditorLabel_ColorG.Name = "EditorLabel_ColorG";
            this.EditorLabel_ColorG.Size = new System.Drawing.Size(15, 16);
            this.EditorLabel_ColorG.TabIndex = 27;
            this.EditorLabel_ColorG.Text = "G";
            // 
            // EditorProjectColorRGB_R
            // 
            this.EditorProjectColorRGB_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditorProjectColorRGB_R.Location = new System.Drawing.Point(120, 289);
            this.EditorProjectColorRGB_R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.EditorProjectColorRGB_R.Name = "EditorProjectColorRGB_R";
            this.EditorProjectColorRGB_R.Size = new System.Drawing.Size(55, 20);
            this.EditorProjectColorRGB_R.TabIndex = 26;
            this.EditorProjectColorRGB_R.ValueChanged += new System.EventHandler(this.EditorProjectColorRGB_UpdateColor);
            // 
            // EditorLabel_ColorR
            // 
            this.EditorLabel_ColorR.AutoSize = true;
            this.EditorLabel_ColorR.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorLabel_ColorR.Location = new System.Drawing.Point(101, 290);
            this.EditorLabel_ColorR.Name = "EditorLabel_ColorR";
            this.EditorLabel_ColorR.Size = new System.Drawing.Size(14, 16);
            this.EditorLabel_ColorR.TabIndex = 25;
            this.EditorLabel_ColorR.Text = "R";
            // 
            // EditorLabel_ProjectColor
            // 
            this.EditorLabel_ProjectColor.AutoSize = true;
            this.EditorLabel_ProjectColor.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorLabel_ProjectColor.Location = new System.Drawing.Point(17, 290);
            this.EditorLabel_ProjectColor.Name = "EditorLabel_ProjectColor";
            this.EditorLabel_ProjectColor.Size = new System.Drawing.Size(78, 16);
            this.EditorLabel_ProjectColor.TabIndex = 24;
            this.EditorLabel_ProjectColor.Text = "Project Color:";
            // 
            // EditorActivityID
            // 
            this.EditorActivityID.AutoSize = true;
            this.EditorActivityID.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorActivityID.Location = new System.Drawing.Point(363, 478);
            this.EditorActivityID.Name = "EditorActivityID";
            this.EditorActivityID.Size = new System.Drawing.Size(13, 13);
            this.EditorActivityID.TabIndex = 23;
            this.EditorActivityID.Text = "0";
            // 
            // EditorLabel_ProjectSelector
            // 
            this.EditorLabel_ProjectSelector.AutoSize = true;
            this.EditorLabel_ProjectSelector.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorLabel_ProjectSelector.Location = new System.Drawing.Point(17, 260);
            this.EditorLabel_ProjectSelector.Name = "EditorLabel_ProjectSelector";
            this.EditorLabel_ProjectSelector.Size = new System.Drawing.Size(79, 16);
            this.EditorLabel_ProjectSelector.TabIndex = 22;
            this.EditorLabel_ProjectSelector.Text = "Project Name:";
            // 
            // EditorAddProject
            // 
            this.EditorAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditorAddProject.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorAddProject.Location = new System.Drawing.Point(374, 257);
            this.EditorAddProject.Name = "EditorAddProject";
            this.EditorAddProject.Size = new System.Drawing.Size(23, 21);
            this.EditorAddProject.TabIndex = 21;
            this.EditorAddProject.Text = "+";
            this.EditorAddProject.UseVisualStyleBackColor = true;
            this.EditorAddProject.Click += new System.EventHandler(this.EditorAddProject_Click);
            // 
            // EditorProjectSelector
            // 
            this.EditorProjectSelector.FormattingEnabled = true;
            this.EditorProjectSelector.Location = new System.Drawing.Point(102, 257);
            this.EditorProjectSelector.Name = "EditorProjectSelector";
            this.EditorProjectSelector.Size = new System.Drawing.Size(274, 21);
            this.EditorProjectSelector.TabIndex = 20;
            this.EditorProjectSelector.SelectionChangeCommitted += new System.EventHandler(this.EditorProjectSelector_SelectionChanged);
            this.EditorProjectSelector.TextChanged += new System.EventHandler(this.EditorProjectSelector_SelectionChanged);
            // 
            // EditorSplitter2
            // 
            this.EditorSplitter2.BackColor = System.Drawing.Color.Silver;
            this.EditorSplitter2.Location = new System.Drawing.Point(10, 250);
            this.EditorSplitter2.Name = "EditorSplitter2";
            this.EditorSplitter2.Size = new System.Drawing.Size(390, 1);
            this.EditorSplitter2.TabIndex = 19;
            this.EditorSplitter2.TabStop = false;
            // 
            // EditorHeader_Project
            // 
            this.EditorHeader_Project.AutoSize = true;
            this.EditorHeader_Project.BackColor = System.Drawing.SystemColors.Control;
            this.EditorHeader_Project.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorHeader_Project.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditorHeader_Project.Location = new System.Drawing.Point(17, 230);
            this.EditorHeader_Project.Name = "EditorHeader_Project";
            this.EditorHeader_Project.Size = new System.Drawing.Size(45, 16);
            this.EditorHeader_Project.TabIndex = 18;
            this.EditorHeader_Project.Text = "Project";
            // 
            // EditorTimeEnd
            // 
            this.EditorTimeEnd.BackColor = System.Drawing.SystemColors.Control;
            this.EditorTimeEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditorTimeEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditorTimeEnd.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorTimeEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditorTimeEnd.Location = new System.Drawing.Point(148, 115);
            this.EditorTimeEnd.Name = "EditorTimeEnd";
            this.EditorTimeEnd.Size = new System.Drawing.Size(85, 25);
            this.EditorTimeEnd.TabIndex = 17;
            this.EditorTimeEnd.Text = "11:59 PM";
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
            // EditorHeader_Time
            // 
            this.EditorHeader_Time.AutoSize = true;
            this.EditorHeader_Time.BackColor = System.Drawing.SystemColors.Control;
            this.EditorHeader_Time.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorHeader_Time.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditorHeader_Time.Location = new System.Drawing.Point(17, 85);
            this.EditorHeader_Time.Name = "EditorHeader_Time";
            this.EditorHeader_Time.Size = new System.Drawing.Size(31, 16);
            this.EditorHeader_Time.TabIndex = 15;
            this.EditorHeader_Time.Text = "Time";
            // 
            // EditorTimeStart
            // 
            this.EditorTimeStart.BackColor = System.Drawing.SystemColors.Control;
            this.EditorTimeStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditorTimeStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditorTimeStart.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorTimeStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditorTimeStart.Location = new System.Drawing.Point(20, 115);
            this.EditorTimeStart.Name = "EditorTimeStart";
            this.EditorTimeStart.Size = new System.Drawing.Size(85, 25);
            this.EditorTimeStart.TabIndex = 14;
            this.EditorTimeStart.Text = "12:00 AM";
            // 
            // CloseEditor
            // 
            this.CloseEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.CloseEditor.BackgroundImage = global::Trackr.Properties.Resources.closeeditor;
            this.CloseEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseEditor.FlatAppearance.BorderSize = 0;
            this.CloseEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseEditor.Location = new System.Drawing.Point(372, 2);
            this.CloseEditor.Name = "CloseEditor";
            this.CloseEditor.Size = new System.Drawing.Size(25, 25);
            this.CloseEditor.TabIndex = 4;
            this.CloseEditor.UseVisualStyleBackColor = false;
            this.CloseEditor.Click += new System.EventHandler(this.CloseEditor_Click);
            this.CloseEditor.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.CloseEditor.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // EditorHeader_ActivityTitle
            // 
            this.EditorHeader_ActivityTitle.AutoSize = true;
            this.EditorHeader_ActivityTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.EditorHeader_ActivityTitle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorHeader_ActivityTitle.ForeColor = System.Drawing.Color.Silver;
            this.EditorHeader_ActivityTitle.Location = new System.Drawing.Point(17, 30);
            this.EditorHeader_ActivityTitle.Name = "EditorHeader_ActivityTitle";
            this.EditorHeader_ActivityTitle.Size = new System.Drawing.Size(73, 16);
            this.EditorHeader_ActivityTitle.TabIndex = 3;
            this.EditorHeader_ActivityTitle.Text = "Activity Title";
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
            this.Minimize.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
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
            this.Maximize.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Maximize.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ClientIcon
            // 
            this.ClientIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientIcon.Image = global::Trackr.Properties.Resources.programico;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Trackr";
            this.Load += new System.EventHandler(this.Main_Load);
            this.EditorPanel.ResumeLayout(false);
            this.EditorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditorProjectColorRGB_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorProjectColorRGB_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorProjectColorRGB_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorSplitter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorSplitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectColorSideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorControlBar)).EndInit();
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
        private System.Windows.Forms.Timer ActivtyTimer;
        internal System.Windows.Forms.Panel ActivitiesDisplay;
        private System.Windows.Forms.Panel EditorPanel;
        private System.Windows.Forms.PictureBox ProjectColorSideBar;
        private System.Windows.Forms.Label EditorTitle;
        private System.Windows.Forms.Label EditorHeader_ActivityTitle;
        private System.Windows.Forms.Button CloseEditor;
        private System.Windows.Forms.PictureBox EditorControlBar;
        private System.Windows.Forms.TextBox EditorActivityTitle;
        private System.Windows.Forms.ComboBox EditorProjectSelector;
        private System.Windows.Forms.PictureBox EditorSplitter2;
        private System.Windows.Forms.Label EditorHeader_Project;
        private System.Windows.Forms.TextBox EditorTimeEnd;
        private System.Windows.Forms.PictureBox EditorSplitter;
        private System.Windows.Forms.Label EditorHeader_Time;
        private System.Windows.Forms.TextBox EditorTimeStart;
        private System.Windows.Forms.Button EditorAddProject;
        private System.Windows.Forms.Label EditorActivityID;
        private System.Windows.Forms.Label EditorLabel_ProjectSelector;
        private System.Windows.Forms.Label EditorLabel_ProjectColor;
        private System.Windows.Forms.Label EditorLabel_ColorG;
        private System.Windows.Forms.Label EditorLabel_ColorR;
        private System.Windows.Forms.Label EditorLabel_ColorB;
        private System.Windows.Forms.Label EditorLabel_EndTime;
        private System.Windows.Forms.Label EditorLabel_StartTime;
        private System.Windows.Forms.Label EditorLabel_ActivityID;
        internal System.Windows.Forms.NumericUpDown EditorProjectColorRGB_G;
        internal System.Windows.Forms.NumericUpDown EditorProjectColorRGB_R;
        internal System.Windows.Forms.NumericUpDown EditorProjectColorRGB_B;
        private System.Windows.Forms.Label EditorLabel_HyphenTimeElapsed;
    }
}

