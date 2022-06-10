using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    public class Cow : Animal
    {
        public Cow()
        { }
        double quantity = 28;
        double prod_price = 14.5;

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
