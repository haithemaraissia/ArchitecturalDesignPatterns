using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Structural.Bridge.Implementor
{
    public interface IBridgeComponents
    {
        void Send(String messageType);
    }
}
