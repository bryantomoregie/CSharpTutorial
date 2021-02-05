using System;
namespace CSharpTutorial
{
    public class Text : PresentationObject
    {
        public int Length { get; set; }

        public void Color()
        {
            Console.WriteLine("Color of text");
        }
    }
}

