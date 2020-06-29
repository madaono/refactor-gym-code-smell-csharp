using System.Collections.Generic;

namespace code_smell_recognise._01
{
    public class Cart
    { 
        List<CartItem> cartItems;

        public void AddCartItem(CartItem cartItem)
        {
            cartItems.Add(cartItem);
        }

        public double GetTotalPrice()
        {
            var result = 0.0;
            foreach (var item in cartItems)
            {
                var subTotal = item.Price * item.Amount * item.Discount;
                result += subTotal;
            }
            
            return result;
        }
    }
}