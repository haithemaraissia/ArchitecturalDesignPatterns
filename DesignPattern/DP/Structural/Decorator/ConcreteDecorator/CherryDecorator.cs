using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Decorator.Component;

namespace DesignPattern.DP.Structural.Decorator.ConcreteDecorator
{
    public class CherryDecorator : Decorator.Decorator
    {
        public CherryDecorator(BakeryComponent mBakeryComponent) : base(mBakeryComponent)
        {
            this.m_Name = "Cherry";
            this.m_Price = 12.00;
        }
    }
}
