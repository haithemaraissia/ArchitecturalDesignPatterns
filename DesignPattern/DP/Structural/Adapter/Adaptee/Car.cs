using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Structural.Adapter.Adaptee
{
    public class Car
    {
        public virtual void Charge()
        {
            Console.WriteLine("Charging Car");
        }
    }
}
