using ProjectRunner.Common.Entities;
using ProjectRunner.Common.Interfaces;
using ProjectRunner.Common.Services;
using ProjectRunner.Common.Tools;
using ProjectRunner.Common.Validators;
using ProjectRunner.Infra.Data.Context;
using ProjectRunner.Infra.Data.Repository;
using System;
using System.Windows.Forms;

namespace ProjectRunner.Desktop.Forms
{
    public delegate void OnProjectSaved(Project project);

    public partial class ProjectForm : Form
    {
        public OnProjectSaved OnProjectSaved;
        public Project Project { get; private set; }
        private IRepositoryService<Project> _service;

        public ProjectForm()
        {
            InitializeComponent();
            Initalization();
        }

        public ProjectForm(Project project)
        {
            InitializeComponent();
            Initalization(project);
        }

        private void Initalization(Project project = null)
        {
            Text = Resources.Strings.Insert + " " +  Resources.Strings.Project;
            LblName.Text = Resources.Strings.Name.Trim();
            LblPath.Text = Resources.Strings.Path.Trim();
            LblExecutable.Text = Resources.Strings.Executable.Trim();
            LblExecutableArgs.Text = Resources.Strings.ExecutableArgs.Trim();
            BtnSave.Text = Resources.Strings.Save.Trim();

            _service = new BaseService<Project>(new BaseRepository<Project>(new SQLiteContext()));

            if (project != null)
            {
                LoadProject(project);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Project == null || Project.Id == 0)
            {
                Project = new Project();
            }

            Project.Name = TbName.Text.Trim();
            Project.Path = TbPath.Text.Trim();
            //Project.Executable = TbExecutable.Text.Trim();
            Project.ExecutableArguments = TbExecutableArgs.Text.Trim();

            try
            {
                _service.Save<ProjectValidator>(Project);
                MessageBox.Show(Resources.Strings.ProjectSaveSuccess);
                OnProjectSaved(Project);
                Close();
            } catch (Exception ex)
            {
                MessageBox.Show(Utils.HandleExceptionMessage(ex));
            } 
        }

        private void LoadProject(Project project)
        {
            Project = project;

            TbName.Text = Project.Name;
            TbPath.Text = Project.Path;
            //TbExecutable.Text = Project.Executable;
            TbExecutableArgs.Text = Project.ExecutableArguments;
        }
    }
}
