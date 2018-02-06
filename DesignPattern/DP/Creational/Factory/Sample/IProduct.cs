using System;

namespace DesignPattern.DP.Creational.Factory.Sample
{
    //PRODUCT
    interface IProduct
    {

    }

    class ConcreteProductA : IProduct
    {
    }

    class ConcreteProductB : IProduct
    {
    }



    //CREATOR
    abstract class Creator
    {
        public abstract IProduct FactoryMethod(string type);
    }

    class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod(string type)
        {
            switch (type)
            {
                case "A": return new ConcreteProductA();
                case "B": return new ConcreteProductB();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
