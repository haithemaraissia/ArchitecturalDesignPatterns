using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Creational.Builder.InvoiceBuilder.Builder
{
    public interface IInvoiceBuilder
    {
        double GetInvoice();
    }
}
