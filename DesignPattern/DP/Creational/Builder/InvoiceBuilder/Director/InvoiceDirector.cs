using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Creational.Builder.InvoiceBuilder.Builder;

namespace DesignPattern.DP.Creational.Builder.InvoiceBuilder.Director
{
    public class InvoiceDirector
    {
        public void Construct(IInvoiceBuilder builder)
        {
            builder.GetInvoice();
        }
    }
}
