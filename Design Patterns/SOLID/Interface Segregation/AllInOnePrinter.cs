using System;

namespace Design_Patterns_Practice.Design_Patterns.SOLID.Interface_Segregation
{
    public class AllInOnePrinter : IPrint, IScan
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning");
        }

        public void Photocopy()
        {
            Console.WriteLine("Photocopy ready");
            Scan();
            Print();
        }
    }
}