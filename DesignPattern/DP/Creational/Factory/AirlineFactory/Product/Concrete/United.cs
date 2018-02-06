using DesignPattern.DP.Creational.Factory.AirlineFactory.Product.Factory;

namespace DesignPattern.DP.Creational.Factory.AirlineFactory.Product.Concrete
{
    public class United : IAirline
    {
        public United()
        {

        }
        double IAirline.GetPrice()
        {
            //Rest API For example
            return 27.00;
        }

    }
}