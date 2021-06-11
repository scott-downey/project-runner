using ProjectRunner.Entities;
using System.Windows.Forms;

namespace ProjectRunner.Desktop.UserControls
{
    public partial class UCProject : UserControl
    {
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
    }
}
