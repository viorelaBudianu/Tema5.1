using System;
using System.Collections.Generic;

namespace Animals

{
    public class Dog:Animal
    {
        public string DogBreed;

        // Constructor
        public Dog(string name, int age, string sex, string Breed) : base(name, age, sex)
        {
            this.DogBreed = Breed;
        }


        //Methods
        // Make sound
        public override void MakeSound()
        {
            Console.WriteLine($"Dog {this.name} say: Ham-Ham");
            
        }

        public static double CalculateAvg(List<Dog> ListOfDogs)
        {
            double sum = 0;

            foreach (var a in ListOfDogs)
            {
                sum += a.Age;
            }

            return sum / ListOfDogs.Count;
        }

    }
}
