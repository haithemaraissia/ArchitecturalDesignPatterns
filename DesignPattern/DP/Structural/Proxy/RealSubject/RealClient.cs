using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Proxy;
using DesignPattern.DP.Structural.Proxy.Subject;

namespace DesignPattern.DP.Structural.Proxy.RealSubject
{
    public class RealClient : Client
    {

        public override void GetData()
        {
            Console.WriteLine("Data From Real Client");
        }
    }
}
