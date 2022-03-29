public class JuniorDeveloperSalary : BaseSalaryCalculator
{
    public JuniorDeveloperSalary(Developer developerReport) : base(developerReport)
    {
    }

    public override double CalculateSalaries() => DeveloperReport.WorkingHours * DeveloperReport.HourlyRate;

}