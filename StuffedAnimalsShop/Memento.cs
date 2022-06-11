using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    public class Memento
    {
        string product;
        double price;

        public string ProductName
        {
            get { return product; }
        }
        public double Price
        {
            get { return price; }
        }
        //constructor
        public Memento(string product, double price)
        {
            this.product = product;
            this.price = price;
        }
    }
    //caretaker
    public class OrderTaker
    {
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
