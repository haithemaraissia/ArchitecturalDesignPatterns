using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Creational.AbstractFactory.Sample;
using DesignPattern.DP.Creational.Builder.Sample;

namespace DesignPattern.DP.Creational
{

    #region Factory

    public class AirlineFact : AirlineFT
    {
        public override IProduct Create(string TypeName)
        {
            return new Deltap();
        }
    }
    public abstract class AirlineFT
    {
        public abstract IProduct Create(string TypeName);
    }

    public interface IProduct
    {

    }

    public class Deltap : IProduct
    {

    }

    #endregion

    #region Builder
    public class Manager
    {
        public static void Build(ICoffe coffe)
        {
            coffe.CoffeePrice();
        }
    }

    public class MockCoffe : ICoffe
    {
        public int CoffeePrice()
        {
            return 45;
        }
    }

    public interface ICoffe
    {
        int CoffeePrice();
    }
    #endregion

    #region Singelton

    public class Person

    {
        private static Person p = new Person();

        private Person() { }

        public static Person Instance
        {
            get
            {
                return p;
            }
        }
    }



    public class LazyPerson
    {
        private static LazyPerson p = null;

        private LazyPerson()
        {

        }

        public static LazyPerson Instance
        {
            get
            {
                if (p == null)
                {
                    p = new LazyPerson();
                }
                return p;
            }
        }
    }


    public class TSPerson
    {
        private static TSPerson person = null;
        private static object Lock = new object();

        private TSPerson()
        {

        }

        public static TSPerson Instance
        {
            get
            {
                if (person == null)
                {
                    lock (Lock)
                    {
                        person = new TSPerson();
                    }
                }
                return person;
            }
        }
    }

    #endregion

    #region  Prototype

    public interface IBook
    {
        IBook Clone();
    }

    public class Novel:IBook
    {
        public string Name { get; set; }
        public IBook Clone()
        {
           return (IBook) MemberwiseClone();
        }
    }

    #endregion

    #region State

    public abstract class State
    {
        public abstract string DoIt(Context x);
    }


    public class FullState : State
    {

        public override string DoIt(Context x)
        {
            return x.DoIt();
        }
    }

    public class Empty : State
    {

        public override string DoIt(Context x)
        {
            return x.DoIt();
        }
    }

    public class Context
    {
        private State s;

        public Context(State x)
        {
            x = s;
        }

        public string DoIt()
        {
            return s.DoIt(this);
        }
    }

    #endregion

    public class Test
    {

        public void Build()
        {
            var director = new Manager();
            ICoffe Coffe = new MockCoffe();
            Manager.Build(Coffe);

        }

        public void Fac()
        {
            var factory = new AirlineFact();
            var detla = factory.Create("delta");
        }

        public void Singelton()
        {
            var a = Person.Instance;
            var b = LazyPerson.Instance;
            var c = TSPerson.Instance;
        }

        public void Prototype()
        {
            Novel z = new Novel();
            z.Name = "What is Up";

            var replicate = (Novel) z.Clone();

        }
    }

}
