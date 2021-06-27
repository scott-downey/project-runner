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
                FileName = dto.Project.Executable,
                Arguments = dto.Project.ExecutableArguments,
                WorkingDirectory = dto.Project.Path,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };
            process.OutputDataReceived += new DataReceivedEventHandler(dto.Logger.ProccessOutoput);
            process.ErrorDataReceived += new DataReceivedEventHandler(dto.Logger.ProccessOutoput);

            dto.Proccess = process;

            _runners.Add(dto);

            return _runners.IndexOf(dto);
        }

        public static void Update(int index, ProjectRunnerDto dto)
        {
            if (dto.Project != null)
            {
                _runners[index].Proccess.StartInfo.FileName = dto.Project.Executable;
                _runners[index].Proccess.StartInfo.Arguments = dto.Project.ExecutableArguments;
                _runners[index].Proccess.StartInfo.WorkingDirectory = dto.Project.Path;
            }

            if (dto.Logger != null)
            {
                _runners[index].Logger = dto.Logger;
                _runners[index].Proccess.OutputDataReceived += new DataReceivedEventHandler(dto.Logger.ProccessOutoput);
                _runners[index].Proccess.ErrorDataReceived += new DataReceivedEventHandler(dto.Logger.ProccessOutoput);
            }
        }

        public static ProjectRunnerDto Get(int index)
        {
            return _runners[index];
        }

        public static Task Run(int index)
        {
            _runners[index].Logger.Clear();
            _runners[index].IsRunning = true;
            _runners[index].Proccess.Start();
            _runners[index].Proccess.BeginOutputReadLine();
            _runners[index].Proccess.BeginErrorReadLine();

            return _runners[index].Proccess.WaitForExitAsync();
        }

        public static void Stop(int index)
        {
            _runners[index].Logger.Add("Project stopped.");
            _runners[index].IsRunning = false;
            _runners[index].Proccess.Kill();
            _runners[index].Proccess.CancelOutputRead();
            _runners[index].Proccess.CancelErrorRead();
            _runners[index].Proccess.Close();
        }
    }
}
