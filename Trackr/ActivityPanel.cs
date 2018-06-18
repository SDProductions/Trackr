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
        public ActivityPanel()
        {
            InitializeComponent();
        }

        private Control GetControl(string key)
        {
            return Main.ActiveForm.Controls.Find(key, true)[0];
        }

        private void ReplaceEditorControl(string key, Control replacement)
        {
            Main.ActiveForm.Controls.Remove(GetControl(key));
            int panelID = Main.ActiveForm.Controls.IndexOf(GetControl("EditorPanel"));
            Main.ActiveForm.Controls[panelID].Controls.Add(replacement);
        }

        private void ExpandActivityInfo_Click(object sender, EventArgs e)
        {
            if (Main.ActiveForm.Size.Width == 350)
            {
                ExpandActivityInfo.Text = "<";

                Control title = GetControl("EditorActivityTitle");
                title.Text = ActivityName.Text;
                ReplaceEditorControl("EditorActivityTitle", title);
                GetControl("EditorActivityTitle").BringToFront();
                Control colorSideBar = GetControl("ProjectColorSideBar");
                colorSideBar.BackColor = ProjectColor.BackColor;
                ReplaceEditorControl("ProjectColorSideBar", colorSideBar);

                for (int t = 0; t < 80; t++)
                {
                    Main.ActiveForm.Size = new Size(Main.ActiveForm.Size.Width + 5, 500);
                }
            }
            else
            {
                ExpandActivityInfo.Text = ">";
                for (int t = 0; t < 80; t++)
                {
                    Main.ActiveForm.Size = new Size(Main.ActiveForm.Size.Width - 5, 500);
                }
            }
        }
    }
}
