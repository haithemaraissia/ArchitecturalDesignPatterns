using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Structural.Bridge.Sample
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    class Abstraction

    {
        protected Implementor implementor;

        // Property
        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>

    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
    /// <summary>
    /// The 'ConcreteImplementorA' class
    /// </summary>

    abstract class Implementor
    {
        public abstract void Operation();
    }
    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// </summary>

    /// <summary>
    /// The 'Implementor' abstract class
    /// </summary>
    /// 
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
