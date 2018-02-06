using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Structural.Adapter.Target
{
    public class Battery
    {
        public virtual void Charge()
        {
            Console.WriteLine("Charging Battery");
        }
    }
}
