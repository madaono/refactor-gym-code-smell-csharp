namespace code_smell_recognise._01
{
    public class CartItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public double Discount { get; set; }

        public CartItem(string name, double price, int amount, double discount)
        {
            Name = name;
            Price = price;
            Amount = amount;
            Discount = discount;
        }
    }
}