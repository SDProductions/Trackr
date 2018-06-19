﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackr
{
    public partial class Main : Form
    {
        private string resourcesFolder = "Resources";
        private string existingProjectsFile = "projects.json";

        private string exportFolder = "Data";

        internal List<ActivityPanel> activities;
        internal ActivityPanel activeActivity;
        internal List<Tuple<string, Color>> projects;

        internal int secondsElapsed = 0;
        internal int minutesElapsed = 0;
        internal int hoursElapsed = 0;

        internal void InitializeActivity()
        {
            if (activities != null)
            {
                for (int p = 0; p < activities.Count(); p++)
                {
                    var controls = Controls[Controls.IndexOfKey("ActivitiesDisplay")].Controls;
                    var control = controls[controls.IndexOf(activities[p])];
                    control.Location = new Point(
                        control.Location.X,
                        control.Location.Y + 60);
                }
            }
            else
            {
                activities = new List<ActivityPanel>();
            }

            Random rnd = new Random();
            var newPanel = new ActivityPanel
            {
                Location = new Point(0, 0)
            };
            if (InputActivity.Text != "What are you doing?")
            {
                newPanel.ActivityName.Text = InputActivity.Text;
            }
            else
            {
                newPanel.ActivityName.Text = "Unknown Activity";
            }
            newPanel.startTime = DateTime.Now.ToShortTimeString();
            newPanel.ProjectName.Text = "No Project";
            newPanel.ProjectColor.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

            activities.Add(newPanel);
            Controls[Controls.IndexOfKey("ActivitiesDisplay")].Controls.Add(newPanel);

            activeActivity = newPanel;
            ActivtyTimer.Start();
            StartInputActivity.Text = "Stop";
            StartInputActivity.BackColor = Color.FromArgb(205, 198, 170);
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(resourcesFolder))
                Directory.CreateDirectory(resourcesFolder);
            if (!Directory.Exists(exportFolder))
                Directory.CreateDirectory(exportFolder);

            if (!File.Exists(resourcesFolder + @"\" + existingProjectsFile))
            {
                File.Create(resourcesFolder + @"\" + existingProjectsFile);
            }
            else
            {
                string json = File.ReadAllText(resourcesFolder + @"\" + existingProjectsFile);
                projects = JsonConvert.DeserializeObject<List<Tuple<string, Color>>>(json);
            }

            if (projects != null)
            {
                for (int p = 0; p < projects.Count; p++)
                {
                    EditorProjectSelector.Items.Add(projects[p].Item1);
                }
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(30, 35, 45);
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(20, 25, 35);
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Maximize_MouseEnter(object sender, EventArgs e)
        {
            Maximize.BackColor = Color.FromArgb(30, 35, 45);
        }

        private void Maximize_MouseLeave(object sender, EventArgs e)
        {
            Maximize.BackColor = Color.FromArgb(20, 25, 35);
        }

        private void ClientControlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(MousePosition.X-175, MousePosition.Y-10);
            }
        }

        private void InputActivity_Click(object sender, EventArgs e)
        {
            InputActivity.Text = "";
        }

        private void StartInputActivity_Click(object sender, EventArgs e)
        {
            if (StartInputActivity.Text == "Stop")
            {
                activeActivity.endTime = DateTime.Now.ToShortTimeString();
                ActivtyTimer.Stop();
                secondsElapsed = 0;
                minutesElapsed = 0;
                hoursElapsed = 0;
                InputActivity.Text = "What are you doing?";
                StartInputActivity.BackColor = Color.Cornsilk;
                StartInputActivity.Text = "Start";
            }
            else
            {
                InitializeActivity();
            }
        }

        private void ActivtyTimer_Tick(object sender, EventArgs e)
        {
            activities.Remove(activeActivity);
            Controls[Controls.IndexOfKey("ActivitiesDisplay")].Controls.Remove(activeActivity);

            secondsElapsed++;
            if (secondsElapsed >= 60)
            {
                secondsElapsed = 0;
                minutesElapsed++;
            }
            if (minutesElapsed >= 60)
            {
                minutesElapsed = 0;
                hoursElapsed++;
            }

            string timeConstruct = "";
            if (hoursElapsed < 10)
            {
                timeConstruct += $"0{hoursElapsed}:";
            }
            else
            {
                timeConstruct += $"{hoursElapsed}:";
            }
            if (minutesElapsed < 10)
            {
                timeConstruct += $"0{minutesElapsed}:";
            }
            else
            {
                timeConstruct += $"{minutesElapsed}:";
            }
            if (secondsElapsed < 10)
            {
                timeConstruct += $"0{secondsElapsed}";
            }
            else
            {
                timeConstruct += $"{secondsElapsed}";
            }

            activeActivity.ActivityTime.Text = $"{timeConstruct}s";

            activities.Add(activeActivity);
            Controls[Controls.IndexOfKey("ActivitiesDisplay")].Controls.Add(activeActivity);
        }

        private void EditorActivityTitle_TextChanged(object sender, EventArgs e)
        {
            //TODO: Update the ActivityPanel and other references to activity
        }

        private void EditorAddProject_Click(object sender, EventArgs e)
        {
            if (EditorProjectSelector.Text != null)
            {

            }
        }

        private void CloseEditor_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < activities.Count; p++)
            {
                activities[p].ExpandActivityInfo.Text = ">";
            }
            for (int t = 0; t < 80; t++)
            {
                Main.ActiveForm.Size = new Size(Main.ActiveForm.Size.Width - 5, 500);
            }
        }
    }
}
