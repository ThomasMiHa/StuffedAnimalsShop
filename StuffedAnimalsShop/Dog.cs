using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    public class Dog : Animal
    {
        public Dog(double prodprice, int quantity)
        {
            this.prod_price = prodprice;
            this.quantity = quantity;
        }
        public Dog() { }
        
        public int DogStock(int ordered)
        {
            return quantity - ordered;

        }
    }
}
