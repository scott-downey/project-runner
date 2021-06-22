using ProjectRunner.Common;
using ProjectRunner.Entities;
using ProjectRunner.Infra.Data.Context;
using ProjectRunner.Infra.Data.Repository;
using ProjectRunner.Interfaces;
using ProjectRunner.Services;
using ProjectRunner.Validators;
using System;
using System.Windows.Forms;

namespace ProjectRunner.Desktop.Forms
{
    public delegate void OnProjectSaved(Project project);

    public partial class ProjectForm : Form
    {
        public OnProjectSaved OnProjectSaved;
        public Project Project { get; private set; }
        private readonly IRepositoryService<Project> _service;

        public ProjectForm()
        {
            InitializeComponent();

            _service = new BaseService<Project>(new BaseRepository<Project>(new SQLiteContext()));
        }

        public ProjectForm(Project project)
        {
            InitializeComponent();

            _service = new BaseService<Project>(new BaseRepository<Project>(new SQLiteContext()));

            LoadProject(project);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Project == null || Project.Id == 0)
            {
                Project = new Project();
            }

            Project.Name = TbName.Text.Trim();
            Project.Path = TbPath.Text.Trim();
            Project.Executable = TbExecutable.Text.Trim();
            Project.ExecutableArguments = TbExecutableArgs.Text.Trim();

            try
            {
                _service.Save<ProjectValidator>(Project);
                MessageBox.Show("The project was successfully saved.");
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
            TbExecutable.Text = Project.Executable;
            TbExecutableArgs.Text = Project.ExecutableArguments;
        }
    }
}
