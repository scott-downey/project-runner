using ProjectRunner.Common.Dto;
using ProjectRunner.Common.Tools;
using ProjectRunner.Common.Entities;
using ProjectRunner.Common.Interfaces;
using ProjectRunner.Common.Services;
using ProjectRunner.Desktop.Forms;
using ProjectRunner.Desktop.Tools;
using ProjectRunner.Infra.Data.Context;
using ProjectRunner.Infra.Data.Repository;
using System;
using System.Windows.Forms;

namespace ProjectRunner.Desktop.UserControls
{
    public delegate void EditActionEvent(ProjectUserControl sender, Project project);
    public delegate void RemoveActionEvent(ProjectUserControl sender);

    public partial class ProjectUserControl : UserControl
    {
        public EditActionEvent EditActionEvent;
        public RemoveActionEvent RemoveActionEvent;
        private Project _project;
        private int _proccesIndex;

        public ProjectUserControl(Project project)
        {
            InitializeComponent();

            SetProject(project);
            SetActionButtonText(false);
            MSManageItems.Text = Resources.Strings.Manage;
            MSManageEditItem.Text = Resources.Strings.Edit;
            MSManageRemoveItem.Text = Resources.Strings.Remove;
            MSManageShowLog.Text = Resources.Strings.Log;
        }

        public void SetProject(Project project)
        {
            _project = project;
            LblProject.Text = _project.Name;

            if (_proccesIndex == 0)
            {
                _proccesIndex = ProjectRunnerService.Create(new ProjectRunnerDto { Project = project });
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
            DialogResult dialogResult = MessageBox.Show(Resources.Strings.ProjectRemoveQuestion, Resources.Strings.ProjectRemove, MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                BaseService<Project> service = new(new BaseRepository<Project>(new SQLiteContext()));

                try
                {
                    service.Destroy(_project.Id);
                    MessageBox.Show(Resources.Strings.ProjectRemoveSuccess);
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
            BtnAction.Text = isRunning ? Resources.Strings.Stop : Resources.Strings.Run;
        }

    }
}
