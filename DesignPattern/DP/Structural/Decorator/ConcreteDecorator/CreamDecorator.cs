using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Decorator.Component;

namespace DesignPattern.DP.Structural.Decorator.ConcreteDecorator
{
    public class CreamDecorator : Decorator.Decorator
    {
        public CreamDecorator(BakeryComponent mBakeryComponent) : base(mBakeryComponent)
        {
            this.m_Name = "Cream";
            this.m_Price = 15.0;
        }
    }
}
