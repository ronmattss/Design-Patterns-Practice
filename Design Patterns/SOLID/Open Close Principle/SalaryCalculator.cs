using System.Collections.Generic;

namespace Design_Patterns_Practice.Design_Patterns.SOLID.Open_Close_Principle
{
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
}