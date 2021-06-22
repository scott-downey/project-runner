using ProjectRunner.Interfaces;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectRunner.Desktop.Tools
{
    class Logger : ILogger
    {
        private Control _logContainer;
        private delegate void SetRunnigLogDelegate(string message = null);

        public Logger(Control logContainer)
        {
            _logContainer = logContainer;
        }

        public void Clear()
        {
            _logContainer.Controls.Clear();
        }

        public void Add(string message = null)
        {
            SetRunnigLog(message);
        }

        public void ProccessOutoput(object sendingProcess, DataReceivedEventArgs outLine)

        {
            _logContainer.Invoke(new SetRunnigLogDelegate(SetRunnigLog), outLine.Data);
        }

        private void SetRunnigLog(string message = null)
        {
            _logContainer.Controls.Add(new Label { Text = message, AutoSize = true, ForeColor = Color.White });
        }
    }
}
