using System;
using System.Collections.Generic;

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

            Console.WriteLine("Open Close Principle");
            Console.WriteLine("============");
            Console.WriteLine("");

            var developers = new List<BaseSalaryCalculator>
            {
                new SeniorDeveloperSalary(new Developer { Id=1, Name="John", WorkingHours = 40, HourlyRate = 20 }),
                new JuniorDeveloperSalary(new Developer { Id=2, Name="Jane", WorkingHours = 20, HourlyRate = 10 }),
                new SeniorDeveloperSalary(new Developer { Id=3, Name="Jack", WorkingHours = 50, HourlyRate = 25 }),
                new JuniorDeveloperSalary(new Developer { Id=4, Name="Jill", WorkingHours = 30, HourlyRate = 15 })
            };

            var calculations = new SalaryCalculator(developers);
            Console.WriteLine("Total salary: " + calculations.CalculateSalaries());



        }
    }
}
