using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFullTask
{
    public abstract class Animal
    {
        public Animal() { }
        public abstract void MakeNoise();

        public abstract void Eat();
    }

    public class Dog : Animal
    { 
        public override void MakeNoise()
        {
            Console.WriteLine("Woof!");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat dog food");
        }
    }

    public class Cat : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat cat food");
        }
    }

}
