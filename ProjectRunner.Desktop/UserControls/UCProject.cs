using ProjectRunner.Common;
using ProjectRunner.Desktop.Forms;
using ProjectRunner.Desktop.Tools;
using ProjectRunner.Dto;
using ProjectRunner.Entities;
using ProjectRunner.Infra.Data.Context;
using ProjectRunner.Infra.Data.Repository;
using ProjectRunner.Interfaces;
using ProjectRunner.Services;
using System;
using System.Windows.Forms;

namespace ProjectRunner.Desktop.UserControls
{
    public delegate void EditActionEvent(UCProject sender, Project project);
    public delegate void RemoveActionEvent(UCProject sender);

    public partial class UCProject : UserControl
    {
        public EditActionEvent EditActionEvent;
        public RemoveActionEvent RemoveActionEvent;
        private ILogger _logger;
        private Project _project;
        private int _proccesIndex;

        public UCProject(Project project)
        {
            InitializeComponent();

            _logger = new Logger(FLPRunningLog);
            SetProject(project);
        }

        public void SetProject(Project project)
        {
            _project = project;
            LblProject.Text = _project.Name;

            if (_proccesIndex == 0)
            {
                _proccesIndex = ProjectRunnerService.Create(new ProjectRunnerDto { Project = project, Logger = _logger });
            }
            else
            {
                ProjectRunnerService.Update(_proccesIndex, new ProjectRunnerDto { Project = project });
            }
        }

        private void MSManageEditItem_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new(_project) { StartPosition = FormStartPosition.CenterParent };
            projectForm.OnProjectSaved = (Project project) => EditActionEvent(this, project);
            projectForm.ShowDialog();
        }

        private void MSManageRemoveItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you remove this project?", "Remove Project", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                BaseService<Project> service = new BaseService<Project>(new BaseRepository<Project>(new SQLiteContext()));

                try
                {
                    service.Destroy(_project.Id);
                    MessageBox.Show("Project was removed.");
                    RemoveActionEvent(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Utils.HandleExceptionMessage(ex));
                }
            }
        }

        private void MSManageShowLog_Click(object sender, EventArgs e)
        {
            PnlRunningLog.Visible = !PnlRunningLog.Visible;
        }

        private async void BtnAction_Click(object sender, EventArgs e)
        {
            bool isRunning = ProjectRunnerService.Get(_proccesIndex).IsRunning;

            try
            {
                if (isRunning)
                {
                    ProjectRunnerService.Stop(_proccesIndex);
                    isRunning = false;
                }
                else
                {
                    SetActionButtonText(isRunning: true);
                    await ProjectRunnerService.Run(_proccesIndex);
                    ProjectRunnerService.Stop(_proccesIndex);
                }
            }
            catch (Exception ex)
            {
                isRunning = false;
                MessageBox.Show(Utils.HandleExceptionMessage(ex));
            }

            SetActionButtonText(isRunning);
        }

        private void SetActionButtonText(bool isRunning)
        {
            BtnAction.Text = isRunning ? "Stop" : "Run";
        }

    }
}
