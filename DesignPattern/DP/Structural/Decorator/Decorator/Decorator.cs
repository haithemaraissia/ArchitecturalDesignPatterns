using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Decorator.Component;

namespace DesignPattern.DP.Structural.Decorator.Decorator
{
    public abstract class Decorator : BakeryComponent
    {
        protected BakeryComponent _component = null;
        protected string m_Name = "Undefined Decorator";
        protected double m_Price = 0.0;

        protected Decorator(BakeryComponent mBakeryComponent)
        {
            _component = mBakeryComponent;
        }


        public override string GetName()
        {
            return string.Format("{0}, {1}", _component.GetName(), m_Name);
        }

        public override double GetPrice()
        {
            return m_Price + _component.GetPrice();
        }
    }
}
