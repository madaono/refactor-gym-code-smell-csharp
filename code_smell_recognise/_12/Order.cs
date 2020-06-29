using System.Collections.Generic;
using System.Linq;

namespace code_smell_recognise._12
{
    public class Order
    {
        public Order(List<LineItem> lineItems, string customerName, string customerAddress)
        {
            this.lineItems = lineItems;
            this.customerName = customerName;
            this.customerAddress = customerAddress;
        }

        List<LineItem> lineItems;
        string customerName;
        string customerAddress;
        
        private double TotalPrice() {
            return lineItems.Select(lineItem => lineItem.Price * lineItem.Quantity).Count();
        }
    }
}