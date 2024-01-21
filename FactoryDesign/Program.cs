using FactoryDesign;

var invoiceObject = InvoiceFactory.GetInvoiceObject("sales");
Console.WriteLine(invoiceObject?.PrintInvoice());