namespace code_smell_recognise._16
{
    public class Order
    {
        private Sku sku;

        private string buyerName;
        private string buyerPhoneNumber;
        private string buyerAddress;

        public Order(Sku sku, string buyerName, string buyerPhoneNumber, string buyerAddress)
        {
            this.sku = sku;
            this.buyerName = buyerName;
            this.buyerPhoneNumber = buyerPhoneNumber;
            this.buyerAddress = buyerAddress;
        }
    }
}