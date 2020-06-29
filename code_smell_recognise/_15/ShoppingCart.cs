using System.Collections.Generic;

namespace code_smell_recognise._15
{
    public class ShoppingCart
    {
        public int ItemsCount { get; set; }
        public double TotalPrice { get; set; }
        public Dictionary<Item, int> Items { get; } = new Dictionary<Item, int>();
        
        public void AddItem(Item item) {
            if (Items.ContainsKey(item)) {
                Items.Add(item, Items[item] + 1);
            } else {
                Items.Add(item, 1);
            }
            TotalPrice += item.Price;
        }
    }
}