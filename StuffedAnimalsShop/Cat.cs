using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    public class Cat : Animal
    {
        public Cat(double prodprice, int quantity)
        {
            this.prod_price = prodprice;
            this.quantity = quantity;
        }
        public Cat()
        { }

    }
}
