using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Creational.Builder.InvoiceBuilder.Builder;

namespace DesignPattern.DP.Creational.Builder.InvoiceBuilder.Concrete
{
    public class GroceryInvoice : IInvoiceBuilder
    {
        public double GetInvoice()
        {
            return 100;
        }
    }
}
