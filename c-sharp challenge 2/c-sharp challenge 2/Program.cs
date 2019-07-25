using System;

namespace c_sharp_challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many animals?");
            
            int numberOfAnimals;

            while (true)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out numberOfAnimals) || numberOfAnimals < 1 || numberOfAnimals > 10)
                {
                    Console.WriteLine("Invalid input. Please ener a number between 1 and 10");
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < numberOfAnimals; i++)
            {
                Console.WriteLine("What kind of animal would you like to create?");
                string animalInput = Console.ReadLine();

                IAnimal myAnimal;

                if (animalInput == "Dog")
                {
                    myAnimal = new Dog($"Dog{i}");
                }
                else
                {
                    myAnimal = new Fish($"Fish{i}");
                }

                myAnimal.Eat("AnimalFood");
                Console.WriteLine(myAnimal.Name);

                if(myAnimal.GetType()  == typeof(Dog))
                {
                    Dog myDog = (Dog)myAnimal;

                    myDog.BarK();
                }
                else if(myAnimal.GetType() == typeof(Fish))
                {
                    Fish myFish = (Fish)myAnimal;
                    myFish.Swim();
                }
            }

        }
    }
}
