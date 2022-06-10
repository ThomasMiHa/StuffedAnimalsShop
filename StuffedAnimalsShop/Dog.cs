using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    public class Dog : Animal
    {
        public Dog()
        { }
        double quantity = 79;
        double prod_price = 9.5;

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
