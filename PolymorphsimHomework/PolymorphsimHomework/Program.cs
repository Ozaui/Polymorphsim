using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Thor");
            Cat cat = new Cat("Odin");

            dog.speak();
            cat.speak();

            Console.ReadLine();
        }
    }
}
