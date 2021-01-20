using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    public class PresentationObject
    {
        public int Width1 { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Copy method");
        }  
        public void Duplicate()
        {
            Console.WriteLine("Duplicate method");
        }
        
    }
}

