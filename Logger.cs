namespace CSharpTutorial
{
    public class Logger 
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message + "!");
        }

        public string Name { get; set; }
    }

}
