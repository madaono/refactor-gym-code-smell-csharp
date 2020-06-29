using System;

namespace code_smell_recognise._15
{
    public class Item
    {
        public string Name { get; set; }
        private double _price;
        
        public double Price
        {
            set => _price = value;
            get => 0;
        }
    }
}