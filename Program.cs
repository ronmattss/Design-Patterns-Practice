using System;

namespace Design_Patterns_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("SRP Principle");
            Console.WriteLine("============");
            Console.WriteLine("");

            Employee employee = new Employee
            {
                FirstName = "John",
                LastName = "Doe",
                Position = "Manager",
                Email = "johnDoeTheManager@gmail.com" 
            };

            EmployeeService employeeService = new EmployeeService();
            employeeService.RegisterNewEmployee(employee);


        }
    }
}
