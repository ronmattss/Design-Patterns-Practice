using System;
using System.Collections.Generic;
using Design_Patterns_Practice.Design_Patterns.SOLID.Liskov_Substitution;
using Design_Patterns_Practice.Design_Patterns.SOLID.Interface_Segregation;
using Design_Patterns_Practice.Design_Patterns.SOLID.Open_Close_Principle;
using Design_Patterns_Practice.Design_Patterns.SOLID.Single_Responsibility;
using Design_Patterns_Practice.Design_Patterns.SOLID.Dependency_Inversion;

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
            Console.WriteLine("============");
            Console.WriteLine("");

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

            Console.WriteLine("============");
            Console.WriteLine("");

            Console.WriteLine("Liskov Substitution Principle");
            Console.WriteLine("============");
            Console.WriteLine("");

            // this example shows Liskov Substitution principle
            Admin admin = new Admin("Admin");
            Editor editor = new Editor("Editor");
            Viewer viewer = new Viewer("Viewer");

            List<Role> roles = new List<Role> { admin, editor, viewer }; // all are derived from the roles class

            admin.MakePost("This is a post by admin");
            editor.EditPost(0, "This is a post by admin : edited by editor");
            System.Console.WriteLine("");

            foreach (var role in roles)
            {
                role.DisplayPost(0);
                System.Console.WriteLine("");
            }
            
            Console.WriteLine("============");
            Console.WriteLine("");
            
            Console.WriteLine("Interface Segregation Principle");
            Console.WriteLine("============");
            
            BasicPrinter basicPrinter = new BasicPrinter();
            AllInOnePrinter allInOnePrinter = new AllInOnePrinter();
            
            basicPrinter.Print();
            
            allInOnePrinter.Print();
            allInOnePrinter.Scan();
            allInOnePrinter.Photocopy();
            
            IPrint printer = allInOnePrinter;
            
            printer.Print();
            printer = basicPrinter;
            printer.Print();
            
            
            Console.WriteLine("============");

            Console.WriteLine("Dependency Inversion Principle");

            IPerson person = Factory.CreatePerson();        // Instead creating an object of the concrete class, we create an object of the interface
            person.Name = "John Doe";
            person.Age = 30;
            person.Work();
            
            ITask task = Factory.CreateTask();
            task.Owner = person;
            task.TaskName = "Create a Dependency Inversion Principle Sample";
            task.MarkComplete();
            
            Console.WriteLine("============");

        }
    }
}
