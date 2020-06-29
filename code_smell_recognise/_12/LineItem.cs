namespace code_smell_recognise._12
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
    }
}