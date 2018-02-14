using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Bridge.Implementor;

namespace DesignPattern.DP.Structural.Bridge.ConcreteImplementor
{
    public class WebService : IBridgeComponents
    {
        public void Send(string messageType)
        {
            Console.WriteLine("Sending " + messageType + " using Webservice");
        }
    }
}
