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
        double quantity = 25;
        double prod_price = 8.5;

        public override double TotalPrice()
        {
            return quantity * prod_price;
        }

        public override double Quantity()
        {
            return quantity;
        }
    }
}
