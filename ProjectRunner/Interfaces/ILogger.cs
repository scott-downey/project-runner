using System.Diagnostics;

namespace ProjectRunner.Interfaces
{
    public interface ILogger
    {
        public void Clear();
        public void Add(string message);
        public void ProccessOutoput(object sendingProcess, DataReceivedEventArgs outLine);
    }
}
