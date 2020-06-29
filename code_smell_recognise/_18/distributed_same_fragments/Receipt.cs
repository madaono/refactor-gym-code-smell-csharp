using System;
using System.Collections.Generic;
using System.Linq;

namespace code_smell_recognise._18.distributed_same_fragments
{
    public class Receipt
    {
        private CustomerName customerName;
        private Address address;
        private List<Item> items;

        public Receipt(CustomerName customerName, Address address, List<Item> items)
        {
            this.customerName = customerName;
            this.address = address;
            this.items = items;
        }
        
        public string GetReceiptString() {
            var customerInformation = "Customer: " +
                                         customerName.Title + customerName.FirstName + " " + customerName.LastName +
                                         Environment.NewLine +
                                         "Address: " +
                                         address.HouseNumber + " " +
                                         address.StreetAddress + ", " +
                                         address.City + ", " +
                                         address.Province + ", " +
                                         address.ZipCode;
            var itemsDetail = "Items: " + Environment.NewLine +
                                 string.Join(Environment.NewLine, items.Select(item => item.Name + " x " + item.Count + ",\\t" + item.Price).ToArray());
            var itemTotal = "Total: " + GetTotal();
            return customerInformation + Environment.NewLine + itemsDetail + Environment.NewLine + itemTotal;
        }

        private decimal GetTotal() {
            return items.Select(item => item.Price * item.Count).Aggregate((acc, i) => acc + i);
        }
    }

    public class Item
    {
        public string Name { get; }
        public decimal Price { get; }
        public int Count { get; }

        public Item(string name, decimal price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
    }
}