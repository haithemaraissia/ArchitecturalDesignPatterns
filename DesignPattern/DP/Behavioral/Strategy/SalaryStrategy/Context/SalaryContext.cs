using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Behavioral.Strategy.SalaryStrategy.Abstract;

namespace DesignPattern.DP.Behavioral.Strategy.SalaryStrategy.Context
{
    public class SalaryContext
    {
        private AbstractEmployeeSalary Salary;
        public SalaryContext(AbstractEmployeeSalary salary)
        {
            Salary = salary;
        }

        public double GetSalary()
        {
            return Salary.GetSalary();
        }
    }
}
