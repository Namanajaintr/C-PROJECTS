using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TightCoupling {
        public float Price = 200;
        public int Quantity = 5;
    }

    public class ShoppingCartContents {
        public TightCoupling[] items;
        //public  TightCoupling[] items = new TightCoupling[] { "eatables","dress","mobile"};
        //public string[] items = new string[] { "eatables", "dress", "mobile" };
    }

    public class Order {
        private ShoppingCartContents cart;
        private float salesTax;

        public Order(ShoppingCartContents cart, float salesTax) {
            this.cart = cart;
            this.salesTax = salesTax;

        }

        public float OrderTotal() {
            float cartTotal = 0;
            for (int i = 0; i < cart.items.Length; i++) {
                cartTotal += cart.items[i].Price * cart.items[i].Quantity;
            }
            cartTotal += cartTotal * salesTax;
            return cartTotal;
        }
    }
}

