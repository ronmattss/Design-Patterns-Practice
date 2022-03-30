namespace Design_Patterns_Practice.Design_Patterns.SOLID.Open_Close_Principle
{
    public class JuniorDeveloperSalary : BaseSalaryCalculator
    {
        public JuniorDeveloperSalary(Developer developerReport) : base(developerReport)
        {
        }

        public override double CalculateSalaries() => DeveloperReport.WorkingHours * DeveloperReport.HourlyRate;

    }
}