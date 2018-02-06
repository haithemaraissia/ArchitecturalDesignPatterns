﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Behavioral.Strategy.SalaryStrategy.Abstract;

namespace DesignPattern.DP.Behavioral.Strategy.SalaryStrategy.Concrete
{
    public class TeamLeadEnginner : AbstractEmployeeSalary
    {
        public override double GetSalary()
        {
            return 120;
        }
    }
}
