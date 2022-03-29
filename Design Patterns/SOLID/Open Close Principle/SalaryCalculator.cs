using System.Collections.Generic;

public class SalaryCalculator
{
    private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;

    public SalaryCalculator(List<BaseSalaryCalculator> developers)
    {
        _developerCalculation = developers;
    }

    public double CalculateSalaries()
    {
        double totalSalaries = 0;
        foreach (var developerCalc in _developerCalculation)
        {
            totalSalaries  += developerCalc.CalculateSalaries();
        }
        return totalSalaries ;
    }
    
}