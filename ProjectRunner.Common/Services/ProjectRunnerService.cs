using ProjectRunner.Common.Dto;
using ProjectRunner.Common.Entities;
using ProjectRunner.Common.Interfaces;
using ProjectRunner.Common.Validators;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRunner.Common.Services
{
    public class ProjectRunnerService
    {
        private static IRepositoryService<Project> _repository;
        private static readonly List<ProjectRunnerDto> _runners = new();

        public static int Create(ProjectRunnerDto dto)
        {
            if (dto.Project.ProcessId != null && ProcessExists(dto.Project.ProcessId.Value))
            {
                dto.Process = Process.GetProcessById(dto.Project.ProcessId.Value);
                dto.IsRunning = true;

                int index = GetRunnerIndex(dto);

                if (index == -1)
                {
                    _runners.Add(dto);
                }
                else
                {
                    _runners[index] = dto;
                }
            }
            else
            {
                CreateRunnerProcess(dto);
            }

            return GetRunnerIndex(dto);
        }

        public static void Update(int index, ProjectRunnerDto dto)
        {
            if (dto.Project != null)
            {
                dto.Process = CreateProcess(dto);
                _runners[index] = dto;
            }
        }

        public static ProjectRunnerDto Get(int index)
        {
            return _runners[index];
        }

        public static Task Run(int index)
        {
            if (!_runners[index].IsRunning)
            {
                if (_runners[index].Process == null)
                {
                    UpdateRunnerProcess(index);
                }

                _runners[index].Process.Start();
                _runners[index].IsRunning = true;

                UpdateProcessId(index, _runners[index].Process.Id);
            }

            return _runners[index].Process.WaitForExitAsync();
        }

        public static void Stop(int index)
        {
            _runners[index].Process.Kill();
            _runners[index].Process.Close();
            _runners[index].Process.Dispose();
            _runners[index].Process = null;
            _runners[index].IsRunning = false;

            UpdateProcessId(index);
        }

        public static void SetRepositoryService(IRepositoryService<Project> repository)
        {
            _repository = repository;
        }

        public static bool ProcessExists(int processId)
        {
            return Process.GetProcesses().Any(p => p.Id == processId);
        }

        private static int GetRunnerIndex(ProjectRunnerDto dto)
        {
            return _runners.FindIndex(r => r.Project.Id == dto.Project.Id);
        }

        private static Process CreateProcess(ProjectRunnerDto dto)
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

            return process;
        }

        private static void CreateRunnerProcess(ProjectRunnerDto dto)
        {
            dto.Process = CreateProcess(dto);
            _runners.Add(dto);
        }

        private static void UpdateRunnerProcess(int index, Process process = null)
        {
            _runners[index].Process = process ?? CreateProcess(_runners[index]);
        }

        private static void UpdateProcessId(int index, int? processId = null)
        {
            if (_repository != null)
            {
                _runners[index].Project.ProcessId = processId;
                _repository.Save<ProjectValidator>(_runners[index].Project);
            }
        }
    }
}
