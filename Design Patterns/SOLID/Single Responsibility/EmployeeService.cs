// This class handles anything related to an Employee

public class EmployeeService
{
    public void RegisterNewEmployee(Employee employee)
    {
        StaticData.Employee.Add(employee); //  The storage is seperated to the logic

        EmailService emailService = new EmailService(); // The EmailService is also seperated as it is not concerned with the employee
        emailService.SendEmail(employee.Email, "Welcome", "Welcome to our company");

    }
}