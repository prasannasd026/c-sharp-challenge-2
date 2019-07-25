using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_challenge_2
{
    interface IAnimal
    {
        string Name { get; }

        void Eat(string food);
    }
}
