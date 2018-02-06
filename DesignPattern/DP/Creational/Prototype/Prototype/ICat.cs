using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Creational.Prototype.Prototype
{
    public interface ICat
    {
        //Shallow Clone
        ICat Clone();

        ////Deep Clone
        //ICat DeepClone();
    }
}
