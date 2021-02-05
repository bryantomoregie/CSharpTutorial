using System;
namespace CSharpTutorial
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

      
        public string Name { get;}

        public int Age { get; set; }

        //public Person(string name, int age)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //}

        public void Introduction()
        {
            Console.WriteLine($"Hello. My name is {Name}.");
            
            
        }

        public void Introduction(string lastName)
        {
            Console.WriteLine($"Hello. My name is {lastName}.");
        }
    }
}
