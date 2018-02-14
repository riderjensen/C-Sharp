using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class SalesInvoice
    {
        private double numberOfItems;
        private double unitPrice;
        private const double STATE_TAX_RATE = 0.0745;
        private const double LOCAL_TAX_RATE = 0.025;
        //Default Constructor 
        public SalesInvoice()
        {
            numberOfItems = 1;
            unitPrice = 1;
        }
        //Parameterized Constructor
        public SalesInvoice(double nOfI, double uP)
        {
            numberOfItems = nOfI;
            unitPrice = uP;
        }
        //Print Invoice
        //Purpose: Print Sales Invoice
        //Input: number of items and sales price
        //Ouput: A string that can be displayed that shows Taxes, Price, and total amount due
        public string PrintInvoice()
        {
            double netPrice = numberOfItems * unitPrice;
            double stateTax = netPrice * STATE_TAX_RATE;
            double localTax = netPrice * LOCAL_TAX_RATE;
            double totalAmountPaid = netPrice + stateTax + localTax;

            string invoice = "Sales reciept";
            invoice = "Number Of Items: \t" + String.Format("{0:f0}", numberOfItems) + "\n";
            invoice += "Unit Price: \t" + String.Format("{0:C}", unitPrice) + "\n";
            invoice += "------------------------------------\n";
            invoice += "Net Price: \t\t" + String.Format("{0:C}", netPrice) + "\n";
            invoice += "State Tax: \t\t" + String.Format("{0:C}", stateTax) + "\n";
            invoice += "Local Tax: \t\t" + String.Format("{0:C}", localTax) + "\n";
            invoice += "Total Amount: \t" + String.Format("{0:C}", totalAmountPaid) + "\n";

            return invoice;
        }


    }
}
