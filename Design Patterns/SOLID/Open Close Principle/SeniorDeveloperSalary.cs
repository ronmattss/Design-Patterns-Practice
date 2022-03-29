public class SeniorDeveloperSalary : BaseSalaryCalculator
{
    public SeniorDeveloperSalary(Developer developerReport) : base(developerReport)
    {
    }

    public override double CalculateSalaries() => DeveloperReport.WorkingHours * DeveloperReport.HourlyRate * 1.5;

}