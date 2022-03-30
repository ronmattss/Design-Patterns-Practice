namespace Design_Patterns_Practice.Design_Patterns.SOLID.Open_Close_Principle
{
    public abstract class BaseSalaryCalculator
    {
        protected Developer DeveloperReport {get; set;}

        protected BaseSalaryCalculator(Developer developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double CalculateSalaries();
    }
}