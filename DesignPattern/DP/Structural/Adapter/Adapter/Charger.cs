using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Adapter.Adaptee;
using DesignPattern.DP.Structural.Adapter.Target;

namespace DesignPattern.DP.Structural.Adapter.Adapter
{
    public class Charger : Battery
    {
        private Car _mycar;

        public Charger()
        {
            _mycar = new Car();
        }

        public override void Charge()
        {
            _mycar.Charge();
        }

    }
}
