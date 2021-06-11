using ProjectRunner.Desktop.Forms;
using ProjectRunner.Entities;
using ProjectRunner.Infra.Data.Context;
using ProjectRunner.Infra.Data.Repository;
using ProjectRunner.Services;
using System;
using System.Windows.Forms;

namespace ProjectRunner.Desktop.UserControls
{
    public partial class UCProject : UserControl
    {
        public EventHandler ManageEndActionEvent;

        private Project _project;

        public UCProject()
        {
            InitializeComponent();
        }

        public UCProject(Project project)
        {
            InitializeComponent();

            _project = project;
            LblProject.Text = _project.Name;
        }

        private void MSManageEditItem_Click(object sender, EventArgs e)
        {
            Form projectForm = new ProjectForm(_project) { StartPosition = FormStartPosition.CenterParent };
            projectForm.FormClosed += (object? sender, FormClosedEventArgs e) => ManageEndActionEvent(sender, e);
            projectForm.ShowDialog();
        }

        private void MSManageRemoveItem_Click(object sender, EventArgs e)
        {
            var service = new BaseService<Project>(new BaseRepository<Project>(new SQLiteContext()));

            try
            {
                service.Destroy(_project.Id);
                MessageBox.Show("Project was removed.");
                ManageEndActionEvent(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utils.HandleExceptionMessage(ex));
            }
        }
    }
}
