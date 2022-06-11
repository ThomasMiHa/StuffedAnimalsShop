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

            //decorator
            Dog ndog = new Dog();
            /*Console.Write("\nSpecial offer for stuffed animal: " + ndog.ExtraType() + "\n");*/

            //for memento - originator
            Order order1 = new Order();
            order1.ProductName = ndog.ExtraType();
            order1.Price = ndog.ProdPrice();
            //store intrernal state
            OrderTaker saveOrder = new OrderTaker();
            saveOrder.Memento = order1.OrderSave();

            ndog = new Nametag(ndog);
            /*Console.WriteLine("> contains: " + ndog.ExtraType());*/

            //changing originator
            Console.WriteLine("\nNew order..");
            order1.ProductName = ndog.ExtraType();
            order1.Price = 14.5;

            //restore
            order1.RestoreOrder(saveOrder.Memento);
        }
    }
}
