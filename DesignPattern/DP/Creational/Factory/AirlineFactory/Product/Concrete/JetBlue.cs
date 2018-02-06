using DesignPattern.DP.Creational.Factory.AirlineFactory.Product.Factory;

namespace DesignPattern.DP.Creational.Factory.AirlineFactory.Product.Concrete
{
    public class JetBlue : IAirline
    {
        public JetBlue()
        {

        }
        double IAirline.GetPrice()
        {
            //Rest API For example
            return 100;
        }

    }
}