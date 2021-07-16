using ProjectRunner.Desktop.UserControls;
using ProjectRunner.Common.Entities;
using ProjectRunner.Common.Services;
using ProjectRunner.Infra.Data.Context;
using ProjectRunner.Infra.Data.Repository;
using System;
using System.Windows.Forms;

namespace ProjectRunner.Desktop.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text = Resources.Strings.AppTitle;
            Resize += MainForm_Resize;
            MaximizeBox = false;
            TpProjects.Text = Resources.Strings.Projects;
            TpExecutables.Text = Resources.Strings.Executables;
            BtnAddProject.Text = Resources.Strings.Add;
            TpSettings.Text = Resources.Strings.Settings;
            BtnAddExecutable.Text = Resources.Strings.Add;
            LblSettingsMinimize.Text = Resources.Strings.MinimizeToStray;
            LblSettingsClose.Text = Resources.Strings.CloseToStray;
            RbSettingsMinimizeYes.Text = Resources.Strings.Yes;
            RbSettingsMinimizeNo.Text = Resources.Strings.No;
            RbSettingsCloseYes.Text = Resources.Strings.Yes;
            RbSettingsCloseNo.Text = Resources.Strings.No;
            BtnSaveSettings.Text = Resources.Strings.Save;

            LoadProjects();
            LoadExecutables();
            LoadSettings();

            ConfigureNotifyIcon();
        }

        #region Form Events
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MinimizeToStray)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    Hide();
                    NotifyIcon.Visible = true;
                }
                else
                {
                    NotifyIcon.Visible = false;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.CloseToStray)
            {
                if (e.CloseReason == CloseReason.WindowsShutDown
                    || e.CloseReason == CloseReason.ApplicationExitCall
                    || e.CloseReason == CloseReason.TaskManagerClosing)
                {
                    return;
                }

                e.Cancel = true;

                Hide();
                NotifyIcon.Visible = true;
            }
        }
        #endregion

        #region Notify Icon Events and Handlers
        private void NotifyIcon_DoubleClick(object Sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void NotifyIconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfigureNotifyIcon()
        {
            ToolStripMenuItem toolStripMenuItem = new()
            {
                Text = Resources.Strings.Exit
            };
            toolStripMenuItem.Click += NotifyIconClose_Click;

            ContextMenuStrip contextMenuStrip = new();
            contextMenuStrip.Items.Add(toolStripMenuItem);

            NotifyIcon.ContextMenuStrip = contextMenuStrip;
            NotifyIcon.DoubleClick += NotifyIcon_DoubleClick;

        }
        #endregion

        #region Project Events and Hanlders
        private void LoadProjects()
        {
            var service = new BaseService<Project>(new BaseRepository<Project>(new SQLiteContext()));
            var projects = service.All();

            FlpProjects.Controls.Clear();

            foreach (var project in projects)
            {
                AddProject(project);
            }
        }

        private void AddProject(Project project)
        {
            ProjectUserControl ucProject = new(project) { EditActionEvent = EditProjectEvent, RemoveActionEvent = RemoveProjectEvent };
            ucProject.MinimumSize = new(PnlProjects.Width - 70, ucProject.MinimumSize.Height);
            ucProject.BorderStyle = BorderStyle.FixedSingle;
            ucProject.Margin = new() { Left = 35, Top = 16 };
            Control[] children = ucProject.Controls.Find("PnlRunningLog", true);

            if (children.Length > 0)
            {
                children[0].MinimumSize = new(ucProject.MinimumSize.Width, children[0].MinimumSize.Height);
            }

            FlpProjects.Controls.Add(ucProject);
        }

        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new() { StartPosition = FormStartPosition.CenterParent };
            projectForm.OnProjectSaved = AddProject;
            projectForm.ShowDialog();
        }

        private static void EditProjectEvent(ProjectUserControl sender, Project project)
        {
            sender.SetProject(project);
        }

        private void RemoveProjectEvent(ProjectUserControl sender)
        {
            FlpProjects.Controls.Remove(sender);
        }
        #endregion

        #region Executable Events And Handlers
        private void BtnAddExecutable_Click(object sender, EventArgs e)
        {
            ExecutableForm executableForm = new() { StartPosition = FormStartPosition.CenterParent };
            executableForm.OnExecutableSaved = AddExecutable;
            executableForm.ShowDialog();
        }

        private void AddExecutable(Executable executable)
        {
            ExecutableUserControl executableUserControl = new(executable) { EditActionEvent = EditExecutabletEvent, RemoveActionEvent = RemoveExecutableEvent };
            executableUserControl.MinimumSize = new(PnlExecutables.Width - 45, executableUserControl.MinimumSize.Height);
            executableUserControl.BorderStyle = BorderStyle.FixedSingle;
            executableUserControl.Margin = new() { Top = 16 };
            FlpExecutables.Controls.Add(executableUserControl);
        }

        private void LoadExecutables()
        {
            var service = new BaseService<Executable>(new BaseRepository<Executable>(new SQLiteContext()));
            var executables = service.All();

            FlpExecutables.Controls.Clear();

            foreach (var executable in executables) {
                AddExecutable(executable);
            }
        }

        private static void EditExecutabletEvent(ExecutableUserControl sender, Executable executable)
        {
            sender.SetExecutable(executable);
        }

        private void RemoveExecutableEvent(ExecutableUserControl sender)
        {
            FlpExecutables.Controls.Remove(sender);
        }
        #endregion

        #region Settings Events and Handlers
        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.MinimizeToStray = RbSettingsMinimizeYes.Checked;
            Properties.Settings.Default.CloseToStray = RbSettingsCloseYes.Checked;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            RbSettingsMinimizeYes.Checked = Properties.Settings.Default.MinimizeToStray == true;
            RbSettingsMinimizeNo.Checked = Properties.Settings.Default.MinimizeToStray == false;
            RbSettingsCloseYes.Checked = Properties.Settings.Default.CloseToStray == true;
            RbSettingsCloseNo.Checked = Properties.Settings.Default.CloseToStray == false;
        }
        #endregion
    }
}
 