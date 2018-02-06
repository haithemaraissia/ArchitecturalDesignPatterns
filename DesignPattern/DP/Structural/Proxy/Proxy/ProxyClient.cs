using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Proxy.RealSubject;
using DesignPattern.DP.Structural.Proxy.Subject;

namespace DesignPattern.DP.Structural.Proxy.Proxy
{
    public class ProxyClient : Client
    {
        private RealClient _realClient;

        public override void GetData()
        {
            if (_realClient == null)
            {
                _realClient = new RealClient();
            }
            _realClient.GetData();
        }
    }
}
