using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Trackr
{
    public partial class Main : Form
    {
        private string resourcesFolder = "Resources";
        private string existingProjectsFile = "projects.json";

        private string exportFolder = "Data";

        internal List<ActivityPanel> activities = new List<ActivityPanel>();
        internal ActivityPanel activeActivity;
        internal List<Tuple<string, Color>> projects = new List<Tuple<string, Color>>();

        internal int secondsElapsed = 0;
        internal int minutesElapsed = 0;
        internal int hoursElapsed = 0;

        private bool mouseDown;
        private Point lastLocation;

        internal string[] monthCodes = {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"};

        internal void InitializeActivity()
        {
            int newActivityID = 0;

            if (activities.Count != 0)
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
            newPanel.ProjectName.Text = QuickProjectSelector.SelectedItem.ToString();
            var projectTuple = (from p in projects
                                where p.Item1 == QuickProjectSelector.SelectedItem.ToString()
                                select p).FirstOrDefault();
            newPanel.ProjectColor.BackColor = projectTuple.Item2;

            activities.Add(newPanel);
            Controls[Controls.IndexOfKey("ActivitiesDisplay")].Controls.Add(newPanel);

            activeActivity = newPanel;
            ActivtyTimer.Start();
            StartInputActivity.Text = "Stop";
            StartInputActivity.BackColor = Color.FromArgb(47, 67, 94);
        }

        struct ActivityInfo
        {
            public string name;
            public string startTime;
            public string endTime;
            public int day;
            public string month;

            public string projName;
            public Color projColor;

            public string details;

            public int ID;
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
                using (var projectsFileStream = File.Create(resourcesFolder + @"\" + existingProjectsFile))
                { }
            }
            else
            {
                string json = File.ReadAllText(resourcesFolder + @"\" + existingProjectsFile);
                projects = JsonConvert.DeserializeObject<List<Tuple<string, Color>>>(json);
            }

            if (projects.Count != 0)
            {
                for (int p = projects.Count - 1; p >= 0; p--)
                {
                    EditorProjectSelector.Items.Add(projects[p].Item1);
                    QuickProjectSelector.Items.Add(projects[p].Item1);
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
                    QuickProjectSelector.Items.Add(projects[p].Item1);
                    if (projects[p].Item1 != "No Project")
                        DeleteProjectSelector.Items.Add(projects[p].Item1);
                }
            }
            QuickProjectSelector.SelectedIndex = QuickProjectSelector.Items.IndexOf("No Project");

            if (File.Exists(exportFolder + @"\latest-export.json"))
            {
                string json = File.ReadAllText(exportFolder + @"\latest-export.json");
                List<ActivityInfo> data = JsonConvert.DeserializeObject<List<ActivityInfo>>(json);

                List<ActivityPanel> loadedPanels = new List<ActivityPanel>();
                foreach (ActivityInfo info in data)
                {
                    var newActivity = new ActivityPanel
                    {
                        startTime = info.startTime,
                        endTime = info.endTime,
                        day = info.day,
                        month = info.month,
                        details = info.details,
                        activityID = info.ID
                    };
                    newActivity.ActivityName.Text = info.name;
                    newActivity.ProjectName.Text = info.projName;
                    newActivity.ProjectColor.BackColor = info.projColor;

                    loadedPanels.Add(newActivity);
                }
                
                int yPos = 0;
                foreach (ActivityPanel panel in loadedPanels)
                {
                    panel.Location = new Point(0, yPos);
                    yPos += 60;
                    activities.Add(panel);
                    ActivitiesDisplay.Controls.Add(panel);
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

        private void EditorMinimize_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (SettingsPanel.Visible)
            {
                SettingsPanel.Visible = false;
            }
            else
            {
                SettingsPanel.Visible = true;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ClientControlBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ClientControlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X,
                                     (Location.Y - lastLocation.Y) + e.Y);
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

        private void InputActivity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                StartInputActivity_Click(sender, e);

                ActiveForm.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void QuickAddProject_Click(object sender, EventArgs e)
        {
            if (Size.Width == 350)
            {
                EditorAddProjectPanel.Visible = true;
                EditorPanel.Visible = false;

                for (int t = 0; t < 50; t++)
                {
                    Main.ActiveForm.Size = new Size(Main.ActiveForm.Size.Width + 8, 500);
                    Update();
                }

                EditorActivityID.Text = "-1";
            }
            else
            {
                EditorAddProjectPanel.Visible = false;
                EditorPanel.Visible = true;

                for (int t = 0; t < 50; t++)
                {
                    Main.ActiveForm.Size = new Size(Main.ActiveForm.Size.Width - 8, 500);
                    Update();
                }
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
            if (hoursElapsed >= 99)
            {
                hoursElapsed = 99;
                minutesElapsed = 59;
                secondsElapsed = 59;
                StartInputActivity_Click(sender, e);
            }

            string timeConstruct = "";
            if (hoursElapsed < 10)
                timeConstruct += $"0{hoursElapsed}:";
            else
                timeConstruct += $"{hoursElapsed}:";

            if (minutesElapsed < 10)
                timeConstruct += $"0{minutesElapsed}:";
            else
                timeConstruct += $"{minutesElapsed}:";

            if (secondsElapsed < 10)
                timeConstruct += $"0{secondsElapsed}";
            else
                timeConstruct += $"{secondsElapsed}";

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
                                               monthCodes.ToList().IndexOf(EditSelectedActivity().month),
                                               EditSelectedActivity().day);
            EditSelectedActivity().day = storedDate.AddDays(1).Day;
            EditSelectedActivity().month = monthCodes[storedDate.AddDays(1).Month];

            EditorCalendarDay.Text = EditSelectedActivity().day.ToString();
            EditorCalendarMonth.Text = EditSelectedActivity().month.ToString();
        }

        private void EditorDatePrevious_Click(object sender, EventArgs e)
        {
            DateTime storedDate = new DateTime(DateTime.Now.Year,
                                              monthCodes.ToList().IndexOf(EditSelectedActivity().month),
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
            try
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
            catch { }
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
            QuickProjectSelector.Items.Clear();
            for (int p = 0; p < projects.Count; p++)
            {
                EditorProjectSelector.Items.Add(projects[p].Item1);
                QuickProjectSelector.Items.Add(projects[p].Item1);
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
            EditorPanel.Visible = false;
            EditorAddProjectPanel.Visible = true;
        }

        private void EditorCancelAddProject_Click(object sender, EventArgs e)
        {
            EditorNewProjectName.Text = "";
            EditorAddProjectPanel.Visible = false;
            EditorPanel.Visible = true;

            if (EditorActivityID.Text == "-1")
            {
                for (int t = 0; t < 50; t++)
                {
                    Main.ActiveForm.Size = new Size(Main.ActiveForm.Size.Width - 8, 500);
                    Update();
                }
            }
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
                QuickProjectSelector.Items.Clear();
                DeleteProjectSelector.Items.Clear();
                for (int p = 0; p < projects.Count; p++)
                {
                    EditorProjectSelector.Items.Add(projects[p].Item1);
                    QuickProjectSelector.Items.Add(projects[p].Item1);
                    if (projects[p].Item1 != "No Project")
                        DeleteProjectSelector.Items.Add(projects[p].Item1);
                }

                EditorProjectSelector.SelectedIndex = EditorProjectSelector.FindStringExact(EditorNewProjectName.Text);
                QuickProjectSelector.SelectedIndex = QuickProjectSelector.FindStringExact(EditorNewProjectName.Text);
                
                EditorNewProjectName.Text = "";
                EditorNewProjectColorRGB_R.Value = 0;
                EditorNewProjectColorRGB_G.Value = 0;
                EditorNewProjectColorRGB_B.Value = 0;


                EditorCancelAddProject_Click(sender, e);
            }
        }

        private void EditorConfirmDeleteProject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DeleteProjectSelector.Text))
            {
                var toRemove = (from p in projects
                                where p.Item1 == DeleteProjectSelector.Text
                                select p).FirstOrDefault();
                projects.Remove(toRemove);

                EditorProjectSelector.Items.Clear();
                QuickProjectSelector.Items.Clear();
                DeleteProjectSelector.Items.Clear();
                for (int p = 0; p < projects.Count; p++)
                {
                    EditorProjectSelector.Items.Add(projects[p].Item1);
                    QuickProjectSelector.Items.Add(projects[p].Item1);
                    if (projects[p].Item1 != "No Project")
                        DeleteProjectSelector.Items.Add(projects[p].Item1);
                }

                EditorProjectSelector.SelectedIndex = EditorProjectSelector.FindStringExact("No Project");
                QuickProjectSelector.SelectedIndex = QuickProjectSelector.FindStringExact("No Project");

                EditorCancelAddProject_Click(sender, e);
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
            for (int t = 0; t < 50; t++)
            {
                Main.ActiveForm.Size = new Size(Main.ActiveForm.Size.Width - 8, 500);
                Update();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(projects);
            File.WriteAllText(resourcesFolder + @"\" + existingProjectsFile, json);
            ExportDataButton_Click(sender, e);
        }

        private void ExportDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                string exportPath = $@"{exportFolder}\latest-export.json";

                List<ActivityInfo> toExport = new List<ActivityInfo>();

                for (int a = 0; a < activities.Count; a++)
                {
                    ActivityPanel selected = activities[a];
                    ActivityInfo exportInfo = new ActivityInfo
                    {
                        name = selected.ActivityName.Text,
                        startTime = selected.startTime,
                        endTime = selected.endTime,
                        day = selected.day,
                        month = selected.month,
                        projName = selected.ProjectName.Text,
                        projColor = selected.ProjectColor.BackColor,
                        details = selected.details,
                        ID = selected.activityID
                    };
                    toExport.Add(exportInfo);
                }

                toExport = toExport.OrderBy(o => o.ID).ToList();
                toExport.Reverse();
                string json = JsonConvert.SerializeObject(toExport, Formatting.Indented);
                File.WriteAllText(exportPath, json);

                NotificationsLabel.Text = $"[{DateTime.Now.ToShortTimeString()}] Exported as latest cumulative datafile.";
            }
            catch
            {
                NotificationsLabel.Text = $"[{DateTime.Now.ToShortTimeString()}] Something went wrong while exporting.";
            }
        }
    }
}