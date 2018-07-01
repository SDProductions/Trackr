using Newtonsoft.Json;
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

        internal string[] monthCodes = {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"};

        internal void InitializeActivity()
        {
            int newActivityID = 0;

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

                newActivityID = activities[(activities.Count - 1)].activityID + 1;
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
            newPanel.activityID = newActivityID;
            newPanel.startTime = DateTime.Now.ToShortTimeString();
            newPanel.day = DateTime.Today.Day;
            newPanel.month = monthCodes[DateTime.Today.Month - 1];
            newPanel.ProjectName.Text = "No Project";
            var noProjectTuple = (from p in projects
                                 where p.Item1 == "No Project"
                                 select p).FirstOrDefault();
            newPanel.ProjectColor.BackColor = noProjectTuple.Item2;

            activities.Add(newPanel);
            Controls[Controls.IndexOfKey("ActivitiesDisplay")].Controls.Add(newPanel);

            activeActivity = newPanel;
            ActivtyTimer.Start();
            StartInputActivity.Text = "Stop";
            StartInputActivity.BackColor = Color.FromArgb(47, 67, 94);
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
                for (int p = projects.Count - 1; p >= 0; p--)
                {
                    EditorProjectSelector.Items.Add(projects[p].Item1);
                }
            }
            else
            {
                projects = new List<Tuple<string, Color>>
                {
                    new Tuple<string, Color>("No Project", Color.Gray)
                };
                for (int p = 0; p < projects.Count; p++)
                {
                    EditorProjectSelector.Items.Add(projects[p].Item1);
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(30, 35, 45);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(20, 25, 35);
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
                activeActivity.endTime = DateTime.Now.ToShortTimeString();
                ActivtyTimer.Stop();
                secondsElapsed = 0;
                minutesElapsed = 0;
                hoursElapsed = 0;
                InputActivity.Text = "What are you doing?";
                StartInputActivity.BackColor = Color.FromArgb(67, 87, 114);
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

        private dynamic EditSelectedActivity()
        {
            return (from a in activities
                    where a.activityID == int.Parse(EditorActivityID.Text)
                    select a).FirstOrDefault();
        }

        private void EditorActivityTitle_TextChanged(object sender, EventArgs e)
        {
            EditSelectedActivity().ActivityName.Text = EditorActivityTitle.Text;
        }

        private void EditorDateNext_Click(object sender, EventArgs e)
        {
            DateTime storedDate = new DateTime(DateTime.Now.Year,
                                               monthCodes.ToList<string>().IndexOf(EditSelectedActivity().month),
                                               EditSelectedActivity().day);
            EditSelectedActivity().day = storedDate.AddDays(1).Day;
            EditSelectedActivity().month = monthCodes[storedDate.AddDays(1).Month];

            EditorCalendarDay.Text = EditSelectedActivity().day.ToString();
            EditorCalendarMonth.Text = EditSelectedActivity().month.ToString();
        }

        private void EditorDatePrevious_Click(object sender, EventArgs e)
        {
            DateTime storedDate = new DateTime(DateTime.Now.Year,
                                              monthCodes.ToList<string>().IndexOf(EditSelectedActivity().month),
                                              EditSelectedActivity().day);
            EditSelectedActivity().day = storedDate.AddDays(-1).Day;
            EditSelectedActivity().month = monthCodes[storedDate.AddDays(-1).Month];

            EditorCalendarDay.Text = EditSelectedActivity().day.ToString();
            EditorCalendarMonth.Text = EditSelectedActivity().month.ToString();
        }

        public void EditorChangeProjectRGB(Color color)
        {
            EditorProjectColorRGB_R.Value = color.R;
            EditorProjectColorRGB_G.Value = color.G;
            EditorProjectColorRGB_B.Value = color.B;
        }

        private void EditorProjectSelector_SelectionChanged(object sender, EventArgs e)
        {
            EditSelectedActivity().ProjectName.Text = EditorProjectSelector.Text;
            if (EditorProjectSelector.Items.Contains(EditSelectedActivity().ProjectName.Text))
            {
                var targetProject = (from p in projects
                                     where p.Item1 == EditSelectedActivity().ProjectName.Text
                                     select p).FirstOrDefault();
                EditSelectedActivity().ProjectColor.BackColor = targetProject.Item2;
                ProjectColorSideBar.BackColor = targetProject.Item2;
                EditorChangeProjectRGB(targetProject.Item2);
            }
        }

        private void EditorProjectColorRGB_UpdateColor(object sender, EventArgs e)
        {
            int RGB_R = int.Parse(EditorProjectColorRGB_R.Value.ToString());
            int RGB_G = int.Parse(EditorProjectColorRGB_G.Value.ToString());
            int RGB_B = int.Parse(EditorProjectColorRGB_B.Value.ToString());
            Color newColor = Color.FromArgb(RGB_R, RGB_G, RGB_B);

            EditSelectedActivity().ProjectColor.BackColor = newColor;
            ProjectColorSideBar.BackColor = newColor;
            EditorChangeProjectRGB(newColor);

            var targetProject = (from p in projects
                                 where p.Item1 == EditSelectedActivity().ProjectName.Text
                                 select p).FirstOrDefault();
            projects.Remove(targetProject);
            projects.Add(new Tuple<string, Color>(targetProject.Item1, newColor));

            EditorProjectSelector.Items.Clear();
            for (int p = 0; p < projects.Count; p++)
            {
                EditorProjectSelector.Items.Add(projects[p].Item1);
            }

            for (int a = 0; a < activities.Count; a++)
            {
                if (activities[a].ProjectName.Text == targetProject.Item1)
                {
                    activities[a].ProjectColor.BackColor = newColor;
                }
            }
        }

        private void EditorAddProject_Click(object sender, EventArgs e)
        {
            EditorAddProjectPanel.Size = new Size(EditorAddProjectPanel.Size.Width, 0);
            EditorAddProjectPanel.Visible = true;
            for (int h = 0; h <= 185; h++)
            {
                EditorAddProjectPanel.Size = new Size(EditorAddProjectPanel.Size.Width, h);
            }
        }

        private void EditorCancelAddProject_Click(object sender, EventArgs e)
        {
            EditorNewProjectName.Text = "";
            for (int h = 185; h >= 0; h--)
            {
                EditorAddProjectPanel.Size = new Size(EditorAddProjectPanel.Size.Width, h);
            }
            EditorAddProjectPanel.Visible = false;
        }

        private void EditorConfirmAddProject_Click(object sender, EventArgs e)
        {
            if (EditorNewProjectName.Text != "" && !EditorProjectSelector.Items.Contains(EditorNewProjectName.Text))
            {
                int projR = int.Parse(EditorNewProjectColorRGB_R.Value.ToString());
                int projG = int.Parse(EditorNewProjectColorRGB_G.Value.ToString());
                int projB = int.Parse(EditorNewProjectColorRGB_B.Value.ToString());
                Tuple<string, Color> newProject = new Tuple<string, Color>(EditorNewProjectName.Text, Color.FromArgb(projR, projG, projB));
                projects.Add(newProject);

                EditorProjectSelector.Items.Clear();
                for (int p = 0; p < projects.Count; p++)
                {
                    EditorProjectSelector.Items.Add(projects[p].Item1);
                }
                EditorNewProjectName.Text = "";
                EditorNewProjectColorRGB_R.Value = 0;
                EditorNewProjectColorRGB_G.Value = 0;
                EditorNewProjectColorRGB_B.Value = 0;
            }
        }

        private void EditorActivityDetails_Click(object sender, EventArgs e)
        {
            if (EditorActivityDetails.Text == "None!")
            {
                EditorActivityDetails.Text = "";
            }
        }

        private void EditorActivityDetails_TextChanged(object sender, EventArgs e)
        {
            EditSelectedActivity().details = EditorActivityDetails.Text;
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