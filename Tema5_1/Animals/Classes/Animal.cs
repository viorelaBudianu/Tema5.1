using System;
using System.Collections.Generic;

namespace Animals

{
    abstract public class Animal:ISound
    {
        public int age;
        public string name;
        public string sex;

        //Proprietati 
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0 || value.GetType() != this.GetType())
                {
                    Console.WriteLine("Insert a valid AGE");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Sex
        {
            get { return this.sex; }
            set
            {
                if (value != "male"||value!="female" || value == null)
                {
                    Console.WriteLine("Insert a valid Sex (male/female)");
                }
                else
                {
                    this.sex = value;
                }
            }
        }

        // Constructor
        public Animal(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        // Methods

        // Produce sound
        public abstract void MakeSound();
        //public static double CalculateAverageAge(List<Animal> animal)
        //{
        //    double sum = 0;

        //    foreach (var a in animal)
        //    {
        //        sum += a.Age;
        //    }

        //    return sum / animal.Count;


        //}
       // public abstract double CalculateAverage(List<Animal> animal);

    }
}
