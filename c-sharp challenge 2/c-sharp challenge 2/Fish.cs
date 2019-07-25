﻿using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_challenge_2
{
    class Fish : IAnimal
    {
        public string Name { get; }

        public Fish(string name)
        {
            Name = name;
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"I'm a fish eating {food}");
        }
    }
}
