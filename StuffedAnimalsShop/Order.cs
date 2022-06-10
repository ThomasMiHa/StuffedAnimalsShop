using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
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
    }
}
