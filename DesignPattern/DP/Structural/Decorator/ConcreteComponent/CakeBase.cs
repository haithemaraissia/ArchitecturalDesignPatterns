using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Decorator.Component;

namespace DesignPattern.DP.Structural.Decorator.ConcreteComponent
{
    public class CakeBase : BakeryComponent
    {
        private string m_Name = "Cake Base";
        private double m_Price = 200.00;

        public override string GetName()
        {
            return m_Name;
        }

        public override double GetPrice()
        {
            return m_Price;
        }
    }
}
