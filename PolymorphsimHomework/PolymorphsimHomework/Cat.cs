using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimHomework
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }

        public override void speak()
        {
            Console.WriteLine(NAME + " is speaking...");
        }
    }
}
