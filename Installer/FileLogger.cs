using System.IO;

namespace CSharpTutorial
{
    public class FileLogger : ILogger
    {
        private string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }


        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }
    }
}
