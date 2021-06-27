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
            BtnAddProject.Text = Resources.Strings.AddProject;
        }

        private void BtnAddProject_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new() { StartPosition = FormStartPosition.CenterParent };
            projectForm.OnProjectSaved = AddProject;
            projectForm.ShowDialog();
        }
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


        private void EditProjectEvent(UCProject sender, Project project)
        {
            sender.SetProject(project);
        }

        private void RemoveProjectEvent(UCProject sender)
        {
            FlPProjects.Controls.Remove(sender);
        }
    }
}
 