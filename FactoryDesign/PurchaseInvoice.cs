using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public class PurchaseInvoice : IInvoice
    {
        public string PrintInvoice()
        {
            return "This is purchase invoice";
        }
    }
}
