namespace CSharpTutorial
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            System.Console.WriteLine("Error:" + message);
        }

        public void LogInfo(string message)
        {
            System.Console.WriteLine("Info:" + message);
        }
    }
}
