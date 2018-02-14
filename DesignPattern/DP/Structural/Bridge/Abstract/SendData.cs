using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Bridge.Implementor;

namespace DesignPattern.DP.Structural.Bridge.Abstract
{
    public abstract class SendData
    {
        public IBridgeComponents _IBridgeComponents;

        public abstract void Send();
    }
}
