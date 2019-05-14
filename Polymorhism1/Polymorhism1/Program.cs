using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism1

{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Animal.Cat cat = new Animal.Cat();
            animal = cat;
            animal.Speak();

            Animal.Chicken chicken = new Animal.Chicken();
            animal = chicken;
            animal.Speak();

            Animal.Dog dog = new Animal.Dog();
            animal = dog;
            animal.Speak();

            Console.ReadKey();
        }
    }
}
