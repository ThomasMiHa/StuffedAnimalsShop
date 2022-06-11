using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    public class Cat : Animal
    {
        public Cat()
        { }
        new double quantity = 25;
        new double prod_price = 8.5;

        public override double TotalPrice()
        {
            return quantity * prod_price;
        }

        public override double Quantity()
        {
            return quantity;
        }
        public override double ProdPrice()
        {
            return prod_price;
        }
    }
}
