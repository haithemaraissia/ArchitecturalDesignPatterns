using System;
using DesignPattern.DP.Creational.Factory.AirlineFactory.Product.Concrete;
using DesignPattern.DP.Creational.Factory.AirlineFactory.Product.Factory;

namespace DesignPattern.DP.Creational.Factory.AirlineFactory.Creator.Concrete
{
    public class ConcreteAirlineFactory : Factory.AirlineFactory
    {
        public override IAirline GetAirline(string airline)
        {
            switch (airline.ToLower())
            {
                case "delta":
                    return new Delta();
                case "jetblue":
                    return new JetBlue();
                case "united":
                    return new United();
                default:
                    throw new Exception(string.Format("Airline : {0}, not implemented", airline ));
            }
        }
    }
}
