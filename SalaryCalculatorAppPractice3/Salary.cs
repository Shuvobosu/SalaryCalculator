using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class Salary
    {
        public string employeeName;
        public double basicAmount;
        public double homeRent;
        public double medicalAllowence;
        
        public double salaryReport(double basic, double hrPercentage, double maPercentage)
        {
            double MainSalary = 0.0;
            MainSalary =basic+ ((basic * hrPercentage) / 100 + (basic * maPercentage) / 100);
            return MainSalary;
        }
    }
}
