using ProjectRunner.Entities;
using ProjectRunner.Interfaces;
using System.Diagnostics;

namespace ProjectRunner.Dto
{
    public class ProjectRunnerDto
    {
        public Project Project { get; set; }
        public ILogger Logger { get; set; }
        public Process Proccess { get; set; }
        public bool IsRunning { get; set; }
    }
}
