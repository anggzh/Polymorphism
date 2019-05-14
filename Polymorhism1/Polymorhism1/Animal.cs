using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism1
{
    class Animal
    {
        public string Name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("The Animal speaks");
        }

        public class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Cat says: Meong-meong");
            }

        }

        public class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Dog says: Guk-guk");
            }

}

        public class Chicken : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Chicken says: Kukuruyuk");
            }
        }
    }
}
