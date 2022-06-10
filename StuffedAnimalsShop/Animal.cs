using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    public abstract class Animal
    {
        protected double prod_price;
        protected double quantity;
        public Animal()
        { }
        public Animal(double p)
        {
            this.prod_price = p;
        }

        public abstract double TotalPrice();

        public abstract double Quantity();
    }
}
