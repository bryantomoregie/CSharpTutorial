using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Console.WriteLine(text is PresentationObject);
            text.Width = 10;
            text.Height = 15;
            Console.WriteLine(text.Width);
            
        }
    }
}
