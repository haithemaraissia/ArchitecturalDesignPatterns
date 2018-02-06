using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Behavioral.State.ConcreteState
{
    public class Full: VendingState
    {

        public override void Handle(VendingMachine context)
        {
            Console.WriteLine("Handle Full State -- Not Refill");
            context.State = new Full();
        }
    }
}
