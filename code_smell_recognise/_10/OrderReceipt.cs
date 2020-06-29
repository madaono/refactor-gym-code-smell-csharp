using System.Text;

namespace code_smell_recognise._10
{
    public class OrderReceipt
    {
        private Order o;

        public OrderReceipt(Order o) {
            this.o = o;
        }

        public string PrintReceipt()
        {
            var output = new StringBuilder();

            // print headers
            output.Append("======Printing Orders======\n");

            // print date, bill no, customer name
//        output.append("Date - " + order.getDate();
            output.Append(o.CustomerName);
            output.Append(o.CustomerAddress);
//        output.append(order.getCustomerLoyaltyNumber());

            // prints lineItems
            var totSalesTx = 0d;
            var tot = 0d;
            foreach (var lineItem in o.LineItems) 
            {
                output.Append(lineItem.Description);
                output.Append('\t');
                output.Append(lineItem.Price);
                output.Append('\t');
                output.Append(lineItem.Quantity);
                output.Append('\t');
                output.Append(lineItem.TotalAmount());
                output.Append('\n');

                // calculate sales tax @ rate of 10%
                var salesTax = lineItem.TotalAmount() * .10;
                totSalesTx += salesTax;

                // calculate total amount of lineItem = price * quantity + 10 % sales tax
                tot += lineItem.TotalAmount() + salesTax;
            }

            // prints the state tax
            output.Append("Sales Tax").Append('\t').Append(totSalesTx);

            // print total amount
            output.Append("Total Amount").Append('\t').Append(tot);
            return output.ToString();
        }
    }
}