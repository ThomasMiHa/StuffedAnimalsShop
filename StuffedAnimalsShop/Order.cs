using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    //originator
    public class Order
    {
        string product;
        double price;

        public string ProductName
        {
            get { return product; }
            set
            {
                product = value;
                Console.WriteLine("\nYou ordered: " + product + " x1");
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                Console.WriteLine("Your order cost: " + price + " Lei");
            }
        }
        //creates memento
        public Memento OrderSave()
        {
            Console.WriteLine("\n>> Saving order..");
            return new Memento(product, price);
        }
        //restore original order state
        public void RestoreOrder(Memento memento)
        {
            Console.WriteLine("\n>> Your first order was:");
            ProductName = memento.ProductName;
            Price = memento.Price;
        }
    }
}
