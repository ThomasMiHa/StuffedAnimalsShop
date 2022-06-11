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
        new double quantity = 79;
        new double prod_price = 9.5;

        public virtual string ExtraType()
        {
            return GetType().Name;
        }
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
