using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimHomework
{
    public class Animal
    {
        private string name;
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void speak()
        {
            Console.WriteLine(name + " is speaking...");
        }
    }
}
