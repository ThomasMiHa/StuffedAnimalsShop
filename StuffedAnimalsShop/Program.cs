using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffedAnimalsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new List<Animal>()
            {
                new Dog(),
                new Cat(),
                new Cow()
            };

            foreach (var stuffedAnimal in animal)
            {
                Console.WriteLine("The stuffed animal " + stuffedAnimal.GetType().Name + " got bought");
            }
        }
    }
}
