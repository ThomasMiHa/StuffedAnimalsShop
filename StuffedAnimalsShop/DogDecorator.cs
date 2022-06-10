using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    public abstract class DogDecorator : Dog
    {
    }

    public class Nametag : DogDecorator
    {
        private Dog dog;
        public Nametag(Dog ndog)
        {
            this.dog = ndog;
        }
        public override string ExtraType()
        {
            return dog.ExtraType() + " with nametag";
        }
    }
}
