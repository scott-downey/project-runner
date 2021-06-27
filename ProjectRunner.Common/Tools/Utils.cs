using System;
using System.IO;

namespace ProjectRunner.Common.Tools
{
    public record DatabaseInfo
    {
        public string Path { get; init; }
        public string Filename { get; init; }
    }

    public class Utils
    {
        public static readonly DatabaseInfo DatabaseInfo = new()
        {
            Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Project Runner"),
            Filename = "ProjectRunner.db"
        };

        public static string HandleExceptionMessage(Exception exception)
        {
            return (exception.InnerException != null) ? exception.Message + Environment.NewLine + exception.InnerException.Message : exception.Message;
        }
    }
}
