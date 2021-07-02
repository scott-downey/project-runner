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
            LoadProjects();
            Text = Resources.Strings.AppTitle;
            MMSProject.Text = Resources.Strings.Project;
            MMSProjectAdd.Text = Resources.Strings.AddProject;
            MMSSettings.Text = Resources.Strings.Settings;
            Resize += MainForm_Resize;
            MaximizeBox = false;

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

        private void MMSSettings_Click(object sender, EventArgs e)
        {
            SettingsForm configForm = new() { StartPosition = FormStartPosition.CenterParent };
            configForm.ShowDialog();
        }

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

            FlPProjects.Controls.Clear();

            foreach (var project in projects)
            {
                AddProject(project);
            }
        }

        private void AddProject(Project project)
        {

            UCProject ucProject = new(project) { EditActionEvent = EditProjectEvent, RemoveActionEvent = RemoveProjectEvent };
            ucProject.MinimumSize = new(PnlProjects.Width - 70, ucProject.MinimumSize.Height);
            ucProject.BorderStyle = BorderStyle.FixedSingle;
            ucProject.Margin = new() { Left = 35, Top = 16 };
            Control[] children = ucProject.Controls.Find("PnlRunningLog", true);

            if (children.Length > 0)
            {
                children[0].MinimumSize = new(ucProject.MinimumSize.Width, children[0].MinimumSize.Height);
            }

            FlPProjects.Controls.Add(ucProject);
        }

        private void MMSProjectAdd_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new() { StartPosition = FormStartPosition.CenterParent };
            projectForm.OnProjectSaved = AddProject;
            projectForm.ShowDialog();
        }


        private void EditProjectEvent(UCProject sender, Project project)
        {
            sender.SetProject(project);
        }

        private void RemoveProjectEvent(UCProject sender)
        {
            FlPProjects.Controls.Remove(sender);
        }
        #endregion
    }
}
 