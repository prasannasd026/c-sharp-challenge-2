using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_challenge_2
{
    class Dog : IAnimal
    {
        public string Name { get; }

        public Dog(string name)
        {
            Name = name;
        }

        public void BarK()
        {
            Console.WriteLine("Woof Woof");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"I'm a dog eating {food}");
        }
    }
}
