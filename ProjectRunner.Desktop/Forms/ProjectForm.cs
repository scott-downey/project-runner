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
    public partial class ProjectForm : Form
    {
        private IService<Project> _service;
        private int _projectId;

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
            Project project = new()
            {
                Name = TbName.Text.Trim(),
                Path = TbPath.Text.Trim(),
                Command = TbCommand.Text.Trim()
            };

            if (_projectId > 0)
            {
                project.Id = _projectId;
            }

            try
            {
                _service.Save<ProjectValidator>(project);
                MessageBox.Show("The project was successfully saved.");
                Close();
            } catch (Exception ex)
            {
                MessageBox.Show(Utils.HandleExceptionMessage(ex));
            } 
        }

        private void LoadProject(Project project)
        {
            _projectId = project.Id;

            TbName.Text = project.Name;
            TbPath.Text = project.Path;
            TbCommand.Text = project.Command;
        }
    }
}
