using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Dog > Dogs = new List<Dog>();
            
            Console.WriteLine("Please provide name of the dog, age, sex");
            Dog d1 = new Dog(Convert.ToString(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToString(Console.ReadLine()),Convert.ToString(Console.ReadLine()));
            Dog d2 = new Dog("Rex", 2, "brr", "Canishe");
            Dog d3 = new Dog("Bob", 3, "male", "Labrador");
            Dog d4 = new Dog("Cujo", 2, "male", "Saint Bernard");
            Dog d5= new Dog("Rex", 6, "female", "German Shepherd");
            Dog d6 = new Dog("Lassie", 4, "female", "Collie");
            Console.WriteLine($"{d1.name} {d1.age} {d1.sex} {d1.DogBreed}");

            Dogs.Add(d1);
            Dogs.Add(d2);
            Dogs.Add(d3);
            Dogs.Add(d4);
            Dogs.Add(d5);
            Dogs.Add(d6);

            //  Console.WriteLine($"Average of dogs' age is:{Dog.CalculateAverageAge(Dogs)}"); // -- daca Dog se mosteneste din Animal, si in clasa Animal am definit o metoda care are ca parametru o lista de Animale, de ce nu pot sa apelez metoda folosind lista de tipul Dog?
            Console.WriteLine($"Average of dogs' age is: {Dog.CalculateAvg(Dogs)}");
            foreach (var d in Dogs)
            {
                d.MakeSound();
            }

            Kitten k1 = new Kitten("Pisi", 1, "male", "persan");

            // Array of cats
            Cat[] cats = new Cat[]
            {
                new Cat("Tom", 2, "male", "rasa1"),
                new Cat("Kat", 5, "female", "rasa2"),
                new Cat("Jerry", 1, "female", "rasa3"),
                new Cat("Gate", 9, "male", "rasa4")
            };
                // Call methods about cats
            Console.WriteLine("Average age of cats are " + Cat.CalculateAvg(cats));
            cats[0].MakeSound();
            cats[3].MakeSound();
            k1.MakeSound();
            ;
        }
        }
    }

