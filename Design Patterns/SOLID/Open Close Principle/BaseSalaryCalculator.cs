public abstract class BaseSalaryCalculator
{
    protected Developer DeveloperReport {get; set;}

    public BaseSalaryCalculator(Developer developerReport)
    {
        DeveloperReport = developerReport;
    }

    public abstract double CalculateSalaries();
}