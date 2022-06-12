using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    public class Animal
    {
        protected double prod_price;
        protected int quantity;
        public Animal()
        { }
        public double TotalPrice()
        {
            return quantity * prod_price;
        }

        public double Quantity()
        {
            return quantity;
        }

        public double ProdPrice()
        {
            return prod_price;
        }

    public virtual string ExtraType()
        {
            return GetType().Name;
        }
    }
}
