using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackr
{
    public partial class Main : Form
    {
        internal List<ActivityPanel> activities;
        internal ActivityPanel activeActivity;
        internal int activitySecondsElapsed = 0;

        internal void InitializeActivity()
        {
            if (activities != null)
            {
                for (int p = 0; p < activities.Count(); p++)
                {
                    var control = Controls[Controls.IndexOf(activities[p])];
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
                Location = new Point(0, 110)
            };
            newPanel.ActivityName.Text = InputActivity.Text;
            newPanel.ProjectColor.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

            activities.Add(newPanel);
            Controls.Add(newPanel);

            activeActivity = newPanel;
            activtyTimer.Start();
            StartInputActivity.Text = "Stop";
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            Close();
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
                activtyTimer.Stop();
                activitySecondsElapsed = 0;
                StartInputActivity.Text = "Start";
            }
            else
            {
                InitializeActivity();
            }
        }

        private void activtyTimer_Tick(object sender, EventArgs e)
        {
            activities.Remove(activeActivity);
            Controls.Remove(activeActivity);
            activeActivity.ActivtyTime.Text = $"{activitySecondsElapsed}s";
            activitySecondsElapsed++;
            activities.Add(activeActivity);
            Controls.Add(activeActivity);
        }
    }
}
