using System;

namespace Animals

{
    public class Cat : Animal
    {
        public string CatBreed;

        //constructor
        public Cat(string Name, int Age, string Sex,string Breed):base(Name,Age,Sex)
        {
            this.CatBreed = Breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.name} Miau-Miaaauuu");
        }

        public static double CalculateAvg(Cat[] cats)
        {
            int sum = 0;
            foreach (var c in cats)
            {
                sum += c.age;
            }
            return sum / cats.Length;
        }
    }
}
