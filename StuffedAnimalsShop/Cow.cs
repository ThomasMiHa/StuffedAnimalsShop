﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    public class Cow : Animal
    {
        public Cow(double prodprice, int quantity)
        {
            this.prod_price = prodprice;
            this.quantity = quantity;
        }
        public Cow()
        { }

    }
}
