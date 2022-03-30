using System.Collections.Generic;

namespace Design_Patterns_Practice.Design_Patterns.SOLID.Single_Responsibility
{
    public class StaticData
    {
        public static List<Employee> Employee{get; set;} = new List<Employee>();
    }
}