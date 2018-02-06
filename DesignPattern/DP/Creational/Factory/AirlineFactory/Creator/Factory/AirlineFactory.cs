using DesignPattern.DP.Creational.Factory.AirlineFactory.Product.Factory;

namespace DesignPattern.DP.Creational.Factory.AirlineFactory.Creator.Factory
{
    public abstract class AirlineFactory
    {
        public abstract IAirline GetAirline(string Airline);
    }
}
