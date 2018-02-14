﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Structural.Decorator.Sample
{
    public class SampleDecorator
    {
        /// <summary>
        /// The 'Component' abstract class
        /// </summary>
        abstract class Component
        {
            public abstract void Operation();
        }

        /// <summary>
        /// The 'ConcreteComponent' class
        /// </summary>
        class ConcreteComponent : Component
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteComponent.Operation()");
            }
        }
        /// <summary>
        /// The 'Decorator' abstract class
        /// </summary>

        abstract class Decorator : Component
        {
            protected Component component;

            public void SetComponent(Component component)
            {
                this.component = component;
            }

            public override void Operation()
            {
                if (component != null)
                {
                    component.Operation();
                }
            }
        }
        /// <summary>
        /// The 'ConcreteDecoratorA' class
        /// </summary>
        class ConcreteDecoratorA : Decorator
        {
            public override void Operation()
            {
                base.Operation();
                Console.WriteLine("ConcreteDecoratorA.Operation()");
            }
        }

        /// <summary>
        /// The 'ConcreteDecoratorB' class
        /// </summary>
        class ConcreteDecoratorB : Decorator
        {
            public override void Operation()
            {
                base.Operation();
                AddedBehavior();
                Console.WriteLine("ConcreteDecoratorB.Operation()");
            }

            void AddedBehavior()
            {
            }
        }
    }
}

