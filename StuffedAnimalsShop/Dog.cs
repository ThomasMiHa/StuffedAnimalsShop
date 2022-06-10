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
        protected string type;
        protected double priceprod;

        public Dog(string type, double priceprod)
        {
            this.type = type;
            this.priceprod = priceprod;
        }

        public virtual string ExtraType()
        {
            return "Dog";
        }
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
