namespace code_smell_recognise._10
{
    public class LineItem
    {
        public LineItem(string description, double price, int quantity)
        {
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public string Description { get; }
        public double Price { get; }
        public int Quantity { get; }

        public double TotalAmount()
        {
            return Price * Quantity;
        }
    }
}