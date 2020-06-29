using System.Collections;
using System.Collections.Generic;

namespace code_smell_recognise._10
{
    public class Order
    {
        public Order(List<LineItem> lineItems, string customerName, string customerAddress)
        {
            LineItems = lineItems;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
        }

        public List<LineItem> LineItems { get; }
        public string CustomerName { get; }
        public string CustomerAddress { get; }
    }
}