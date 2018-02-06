namespace DesignPattern.DP.Creational.AbstractFactory.Sample
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }

    public class ConcreteFactoryA : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactoryB : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }




    public interface IAbstractProductA { }

    public class ProductA1 : IAbstractProductA { }

    public class ProductA2 : IAbstractProductA { }




    public interface IAbstractProductB { }

    public class ProductB1 : IAbstractProductB { }

    public class ProductB2 : IAbstractProductB { }




    public class Client
    {
        private IAbstractProductA _productA;
        private IAbstractProductB _productB;

        public Client(IAbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }
    }
}
