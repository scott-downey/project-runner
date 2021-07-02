using System;
using System.Windows.Forms;

namespace ProjectRunner.Desktop.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadSettings();
            Text = Resources.Strings.Settings;
            LblMinimize.Text = Resources.Strings.MinimizeToStray;
            LblClose.Text = Resources.Strings.CloseToStray;
            BtnSave.Text = Resources.Strings.Save;
        }

        private void LoadSettings()
        {
            RbMinimizeYes.Checked = Properties.Settings.Default.MinimizeToStray == true;
            RbMinimizeNo.Checked = Properties.Settings.Default.MinimizeToStray == false;
            RbCloseYes.Checked = Properties.Settings.Default.CloseToStray == true;
            RbCloseNo.Checked = Properties.Settings.Default.CloseToStray == false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MinimizeToStray = RbMinimizeYes.Checked;
            Properties.Settings.Default.CloseToStray = RbCloseYes.Checked;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
