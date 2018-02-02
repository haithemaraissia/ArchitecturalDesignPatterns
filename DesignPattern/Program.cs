using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Creational.Builder.InvoiceBuilder.Builder;
using DesignPattern.DP.Creational.Builder.InvoiceBuilder.Concrete;
using DesignPattern.DP.Creational.Builder.InvoiceBuilder.Director;
using DesignPattern.DP.Creational.Builder.Sample;
using DesignPattern.DP.Creational.Factory.AirlineFactory.Creator.Concrete;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // FactoryPattern();
            BuilderPattern();
            Console.ReadLine();
        }

        #region FactoryPattern
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
            }
        }

        #endregion

        #region BuilderPattern

        private static void BuilderPattern()
        {
            var invoiceDirector = new InvoiceDirector();
            IInvoiceBuilder invoice = new GazInvoice();
            invoiceDirector.Construct(invoice);
            Console.Write("Construction of Gaz's Invoice : {0}", invoice.GetInvoice());
        }


  
      


        #endregion
    }
}
