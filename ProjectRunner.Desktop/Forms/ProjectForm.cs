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

        public ProjectForm()
        {
            InitializeComponent();

            _service = new BaseService<Project>(new BaseRepository<Project>(new SQLiteContext()));
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Project project = new()
            {
                Name = TbName.Text.Trim(),
                Path = TbPath.Text.Trim(),
                Command = TbCommand.Text.Trim()
            };

            try
            {
                _service.Save<ProjectValidator>(project);
                MessageBox.Show("The project was successfully saved.");
                Close();
            } catch (Exception ex)
            {
                string message = ex.Message;
                message = (ex.InnerException != null) ? message + Environment.NewLine + ex.InnerException.Message : message;
                MessageBox.Show(message);
            } 
        }
    }
}
