using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Bridge.Abstract;

namespace DesignPattern.DP.Structural.Bridge.RefinedAbstraction
{
    public class SendEmail: SendData
    {
        public override void Send()
        {
            _IBridgeComponents.Send("Email");
        }
    }
}
