using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public static class InvoiceFactory
    {
        public static IInvoice? GetInvoiceObject(string type)
        {
            IInvoice invoice = null;
            if (type == "sales")
                invoice = new SalesInvoicecs();
            else if(type=="purchase")
                invoice= new PurchaseInvoice();
            return invoice;
        }
    }
}
