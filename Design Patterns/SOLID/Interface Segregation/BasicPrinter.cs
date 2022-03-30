using System;

namespace Design_Patterns_Practice.Design_Patterns.SOLID.Interface_Segregation
{
    public class BasicPrinter : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Basic Printer");
        }
    }
}