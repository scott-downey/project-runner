using ProjectRunner.Common.Dto;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjectRunner.Common.Services
{
    public class ProjectRunnerService
    {
        private static readonly List<ProjectRunnerDto> _runners = new();

        public static int Create(ProjectRunnerDto dto)
        {
            Process process = new();
            process.StartInfo = new ProcessStartInfo
            {
                FileName = dto.Project.Executable.FileName,
                Arguments = dto.Project.ExecutableArguments,
                WorkingDirectory = dto.Project.Path,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            dto.Proccess = process;

            _runners.Add(dto);

            return _runners.IndexOf(dto);
        }

        public static void Update(int index, ProjectRunnerDto dto)
        {
            if (dto.Project != null)
            {
                _runners[index].Proccess.StartInfo.FileName = dto.Project.Executable.FileName;
                _runners[index].Proccess.StartInfo.Arguments = dto.Project.ExecutableArguments;
                _runners[index].Proccess.StartInfo.WorkingDirectory = dto.Project.Path;
            }
        }

        public static ProjectRunnerDto Get(int index)
        {
            return _runners[index];
        }

        public static Task Run(int index)
        {
            _runners[index].IsRunning = true;
            _runners[index].Proccess.Start();

            return _runners[index].Proccess.WaitForExitAsync();
        }

        public static void Stop(int index)
        {
            _runners[index].IsRunning = false;
            _runners[index].Proccess.Kill();
            _runners[index].Proccess.Close();
        }
    }
}
