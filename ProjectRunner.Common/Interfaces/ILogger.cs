using System.Diagnostics;

namespace ProjectRunner.Common.Interfaces
{
    public interface ILogger
    {
        public void Clear();
        public void Add(string message);
        public void ProccessOutoput(object sendingProcess, DataReceivedEventArgs outLine);
    }
}
