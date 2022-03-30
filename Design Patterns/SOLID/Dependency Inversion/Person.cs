using System;

namespace Design_Patterns_Practice.Design_Patterns.SOLID.Dependency_Inversion
{
    public class Person : IPerson
    {
        public  string Name { get; set; }
        public int Age { get; set; }
        public void Work()
        {
            Console.WriteLine("I am working");
        }
    }
}