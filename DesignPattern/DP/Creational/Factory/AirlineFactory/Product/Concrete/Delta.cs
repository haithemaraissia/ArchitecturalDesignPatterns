using DesignPattern.DP.Creational.Factory.AirlineFactory.Product.Factory;

namespace DesignPattern.DP.Creational.Factory.AirlineFactory.Product.Concrete
{
    public class Delta : IAirline
    {
        public Delta()
        {
            
        }
        double IAirline.GetPrice()
        {
            //Rest API For example
            return 55.25;
        }

    }
}