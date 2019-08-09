using AnimateForms.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackr
{
    public partial class Main : Form
    {
        private readonly string resourcesFolder = "Resources";
        private readonly string projectsFile = "projects.json";
        
        internal ActivityPanel activeActivity;
        internal List<ActivityPanel> activities = new List<ActivityPanel>();
        internal List<Tuple<string, Color>> projects;

        // Handle custom drag interface
        private bool mouseDown;
        private Point lastLocation;

        // Look mum, it's the thing I made!
        private readonly Animate _a = new Animate();

        internal bool _isExpanded = false;

        #region Startup
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Check if directory & file exists already
            if (!Directory.Exists(resourcesFolder))
                Directory.CreateDirectory(resourcesFolder);

            // If file does not exist, create new
            if (!File.Exists(resourcesFolder + @"\" + projectsFile))
            {
                projects = new List<Tuple<string, Color>>
                {
                    new Tuple<string, Color>("No Project", Color.Gray)
                };
                File.Create(resourcesFolder + @"\" + projectsFile).Close();
            }
            // If file exists, deserialize to object
            else
            {
                string json = File.ReadAllText(resourcesFolder + @"\" + projectsFile);
                projects = JsonConvert.DeserializeObject<List<Tuple<string, Color>>>(json);
            }

            // Add projects to relevant selectors
            for (int p = projects.Count - 1; p >= 0; p--)
            {
                EditorProjectSelector.Items.Add(projects[p].Item1);
                QuickProjectSelector.Items.Add(projects[p].Item1);
                if (projects[p].Item1 != "No Project")
                    DeleteProjectSelector.Items.Add(projects[p].Item1);
            }

            QuickProjectSelector.SelectedIndex = QuickProjectSelector.Items.IndexOf("No Project");
        }
        #endregion

        #region Basic Window Functions
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(69, 77, 117);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(52, 57, 83);
        }

        private void SecondaryButton_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(77, 97, 124);
        }

        private void EditorMinimize_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromKnownColor(KnownColor.Control);
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
                Location = new Point((Location.X - lastLocation.X) + e.X,
                                     (Location.Y - lastLocation.Y) + e.Y);
        }

        // Expands the window using AnimateForms (QuadInOut, 500ms)
        private async Task ExpandWindow()
        {
            await _a.Resize(ActiveForm, Easings.QuadInOut, 500,
                          new Size(1000, ActiveForm.Height));
            _isExpanded = true;
        }

        // Contrats the window using AnimateForms (QuadInOut, 500ms)
        private async Task UnexpandWindow()
        {
            await _a.Resize(ActiveForm, Easings.QuadInOut, 500,
                          new Size(467, ActiveForm.Height));
            _isExpanded = false;
        }

        private async void ShowActivityInfo(object sender, EventArgs e)
        {
            if (!_isExpanded)
            {
                EditorAddProjectPanel.Visible = false;
                EditorPanel.Visible = true;
                await ExpandWindow();
            }
            else if (!EditorPanel.Visible)
            {
                await UnexpandWindow();
                EditorAddProjectPanel.Visible = false;
                EditorPanel.Visible = true;
                await ExpandWindow();
            }
            else if (sender.GetType() == typeof(ActivityPanel) &&
                    (sender as ActivityPanel).activityID != int.Parse(EditorActivityID.Text))
            {
                await UnexpandWindow();
                await ExpandWindow();
            }
            else await UnexpandWindow();
        }
        #endregion

        #region Trackr - Main Controls
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
                InputActivity.Text = "What are you doing?";
                StartInputActivity.BackColor = Color.FromArgb(67, 87, 114);
                StartInputActivity.Text = "Start";
            }
            else
                InitializeActivity();
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

        private async void QuickAddProject_Click(object sender, EventArgs e)
        {
            if (!_isExpanded)
            {
                EditorAddProjectPanel.Visible = true;
                EditorPanel.Visible = false;
                await ExpandWindow();

                EditorActivityID.Text = "-1";
            }
            else if (!EditorAddProjectPanel.Visible)
            {
                await UnexpandWindow();
                EditorAddProjectPanel.Visible = true;
                EditorPanel.Visible = false;
                await ExpandWindow();
            }
            else await UnexpandWindow();
        }
        #endregion

        #region Trackr - ActivityPanel Management
        private void InitializeActivity()
        {
            int newActivityID = (activities.LastOrDefault() == null ? 0 : activities.Last().activityID) + 1;
            var newPanel = new ActivityPanel
            {
                Location = new Point(0, 0),
                activityID = newActivityID,
            };
            newPanel.OnExpandRequest += new EventHandler(ShowActivityInfo);

            // Set activity name
            if (InputActivity.Text != "What are you doing?")
                newPanel.ActivityName.Text = InputActivity.Text;
            else
                newPanel.ActivityName.Text = "An Activity";

            // Set project name and color - TODO: make projects less icky
            newPanel.ProjectName.Text = QuickProjectSelector.SelectedItem.ToString();
            var projectTuple = (from p in projects
                                where p.Item1 == QuickProjectSelector.SelectedItem.ToString()
                                select p).FirstOrDefault();
            newPanel.ProjectColor.BackColor = projectTuple.Item2;

            // Shift every other activity down
            if (activities.Count != 0)
                _ = _a.MoveRelative(new Options(Helpers.CollectionToArray(ActivitiesDisplay.Controls), 
                                    Easings.QuadInOut, 500), new Point(0, newPanel.Height));

            // Display new activity & start timer
            activities.Add(newPanel);
            ActivitiesDisplay.Controls.Add(newPanel);

            activeActivity = newPanel;
            ActivtyTimer.Start();
            StartInputActivity.Text = "Stop";
        }

        private void ActivtyTimer_Tick(object sender, EventArgs e)
        {
            // if time difference greater than a day, display day counter
            if ((DateTime.Now - activeActivity.startTime).Days != 0)
                activeActivity.ActivityTime.Text = (DateTime.Now - activeActivity.startTime).ToString(@"d\.hh\:mm\:ss");
            else
                activeActivity.ActivityTime.Text = (DateTime.Now - activeActivity.startTime).ToString(@"hh\:mm\:ss");

            // if time difference is negative, switch colors to red to denote countdown
            if ((DateTime.Now - activeActivity.startTime).Seconds < 0)
                activeActivity.ActivityTime.ForeColor = Color.FromArgb(224, 102, 102);
            else
                activeActivity.ActivityTime.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
        }
        #endregion

        private ActivityPanel EditSelectedActivity()
        {
            return (from a in activities
                    where a.activityID == int.Parse(EditorActivityID.Text)
                    select a).FirstOrDefault();
        }

        #region Editor - Date and Time
        private void EditorDateNext_Click(object sender, EventArgs e)
        {
            //add one day to selected activity
            EditSelectedActivity().startTime = EditSelectedActivity().startTime.AddDays(1);

            //update this on the editor
            EditorCalendarDay.Text = EditSelectedActivity().startTime.Day.ToString();
            EditorCalendarMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(EditSelectedActivity().startTime.Month);
        }

        private void EditorDatePrevious_Click(object sender, EventArgs e)
        {
            //subtract one day to selected activity
            EditSelectedActivity().startTime = EditSelectedActivity().startTime.AddDays(-1);

            //update this on the editor
            EditorCalendarDay.Text = EditSelectedActivity().startTime.Day.ToString();
            EditorCalendarMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(EditSelectedActivity().startTime.Month);
        }
        #endregion

        #region Editor - Projects
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
            int RGB_R = (int)EditorProjectColorRGB_R.Value;
            int RGB_G = (int)EditorProjectColorRGB_G.Value;
            int RGB_B = (int)EditorProjectColorRGB_B.Value;
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
                    activities[a].ProjectColor.BackColor = newColor;
            }
        }

        private void EditorAddProject_Click(object sender, EventArgs e)
        {
            EditorPanel.Visible = false;
            EditorAddProjectPanel.Visible = true;
        }

        private async void EditorCancelAddProject_Click(object sender, EventArgs e)
        {
            if (EditorActivityID.Text == "-1")
                await UnexpandWindow();

            EditorNewProjectName.Text = "";
            EditorAddProjectPanel.Visible = false;
            EditorPanel.Visible = true;
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
        #endregion

        #region Editor - Title and Description
        private void EditorActivityTitle_TextChanged(object sender, EventArgs e)
        {
            EditSelectedActivity().ActivityName.Text = EditorActivityTitle.Text;
        }

        private void EditorActivityDetails_Click(object sender, EventArgs e)
        {
            if (EditorActivityDetails.Text == "None!")
                EditorActivityDetails.Text = "";
        }

        private void EditorActivityDetails_TextChanged(object sender, EventArgs e)
        {
            EditSelectedActivity().details = EditorActivityDetails.Text;
        }
        #endregion

        private async void CloseEditor_Click(object sender, EventArgs e)
        {
            await UnexpandWindow();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(projectsFile, JsonConvert.SerializeObject(projects));
        }
    }
}