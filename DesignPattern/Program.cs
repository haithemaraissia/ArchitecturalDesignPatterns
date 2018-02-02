using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Creational.Factory;
using DesignPattern.DP.Creational.Factory.Example.AirlineFactory.Creator.Concrete;
using DesignPattern.DP.Creational.Factory.Example.AirlineFactory.Creator.Factory;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryPattern();
        }

        private static void FactoryPattern()
        {
            var airlines = new string[]
            {
                "delta",
                "jetblue",
                "united"
            };

            var factory = new ConcreteAirlineFactory();

            foreach (var airline in airlines)
            {
                var airlineType = factory.GetAirline(airline);
                Console.Write("Airline: {0} -- Price: {1}", airline, airlineType.GetPrice());
                Console.ReadLine();
            }
        }
    }
}
