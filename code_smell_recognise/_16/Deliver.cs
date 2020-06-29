namespace code_smell_recognise._16
{
    public class Deliver
    {
        private int deliverNumber;

        private string size;
        private string weight;

        private string buyerName;
        private string buyerPhoneNumber;
        private string buyerAddress;

        public Deliver(int deliverNumber, string size, string weight, string buyerName, string buyerPhoneNumber, string buyerAddress)
        {
            this.deliverNumber = deliverNumber;
            this.size = size;
            this.weight = weight;
            this.buyerName = buyerName;
            this.buyerPhoneNumber = buyerPhoneNumber;
            this.buyerAddress = buyerAddress;
        }
    }
}