using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackr
{
    public partial class ActivityPanel : UserControl
    {
        public int activityID = -1;
        public string startTime = "--:-- --";
        public string endTime = "00:00 PM";
        public int day = 1;
        public string month = "JAN";
        public string details = "None!";
        
        public ActivityPanel()
        {
            InitializeComponent();
        }

        private Control GetControl(string key)
        {
            return Main.ActiveForm.Controls.Find(key, true)[0];
        }

        private void SetEditorInfo()
        {
            Control id = GetControl("EditorActivityID");
            id.Text = this.activityID.ToString();

            Control title = GetControl("EditorActivityTitle");
            title.Text = ActivityName.Text;
            title.BringToFront();

            Control project = GetControl("EditorProjectSelector");
            project.Text = ProjectName.Text;
            NumericUpDown colorR = GetControl("EditorProjectColorRGB_R") as NumericUpDown;
            colorR.Value = ProjectColor.BackColor.R;
            NumericUpDown colorG = GetControl("EditorProjectColorRGB_G") as NumericUpDown;
            colorG.Value = ProjectColor.BackColor.G;
            NumericUpDown colorB = GetControl("EditorProjectColorRGB_B") as NumericUpDown;
            colorB.Value = ProjectColor.BackColor.B;

            Control colorSideBar = GetControl("ProjectColorSideBar");
            colorSideBar.BackColor = ProjectColor.BackColor;

            Control startTime = GetControl("EditorTimeStart");
            startTime.Text = this.startTime;
            Control endTime = GetControl("EditorTimeEnd");
            endTime.Text = this.endTime;
            Control day = GetControl("EditorCalendarDay");
            day.Text = this.day.ToString();
            Control month = GetControl("EditorCalendarMonth");
            month.Text = this.month;

            Control details = GetControl("EditorActivityDetails");
            details.Text = this.details;
        }

        private void ExpandActivityInfo_Click(object sender, EventArgs e)
        {
            if (Main.ActiveForm.Size.Width == 350)
            {
                SetEditorInfo();

                for (int t = 0; t < 80; t++)
                {
                    Main.ActiveForm.Size = new Size(Main.ActiveForm.Size.Width + 5, 500);
                }
            }
            else
            {
                for (int t = 0; t < 80; t++)
                {
                    Main.ActiveForm.Size = new Size(Main.ActiveForm.Size.Width - 5, 500);
                }
                
                if (!(int.Parse(GetControl("EditorActivityID").Text) == this.activityID))
                {
                    SetEditorInfo();

                    for (int t = 0; t < 80; t++)
                    {
                        Main.ActiveForm.Size = new Size(Main.ActiveForm.Size.Width + 5, 500);
                    }
                }
            }
        }
    }
}
