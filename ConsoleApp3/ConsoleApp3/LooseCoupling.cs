//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class LooseCoupling
//    {
//        public float Price;
//        public int Quantity;
//        public int Discount;

//        public float GetRowItemTotal() {
//            return Price * Quantity - Discount;
//        }
//    }

//    public class ShoppingCart
//    {
//        public LooseCoupling[] cartitems;



//        public float GetCartItemsTotal() {
//            float cartTotal = 0;
//            foreach (LooseCoupling item in cartitems) {
//                cartTotal += item.GetRowItemTotal();
//            }
//            return cartTotal;
//        }
//    }

//    public class Order1
//    {
//        private ShoppingCart cart;
//        private float salesTax;

//        public Order1(ShoppingCart cart, float salesTax) {
//            this.cart = cart;
//            this.salesTax = salesTax;
//        }

//        public float OrderTotal() {
//            return cart.GetCartItemsTotal() * (2.0f + salesTax);
//        }
//    }
//}

