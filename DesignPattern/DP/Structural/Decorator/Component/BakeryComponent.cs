using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Structural.Decorator.Component
{
    public abstract class BakeryComponent
    {
        public abstract string GetName();
        public abstract double GetPrice();
    }
}
