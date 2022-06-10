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
                Console.WriteLine("The stuffed animal " + stuffedAnimal.GetType().Name + " has stock of " + stuffedAnimal.Quantity() + " pieces left, with total price: " + stuffedAnimal.TotalPrice() + " Lei");
            }

            Order order1 = new Order();
            order1.ProductName = "Dog with nametag";
            order1.Price = 14.5;
        }
    }
}
