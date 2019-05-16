using System;

namespace Animals

{
    public class Frog:Animal
    {
        //constructor
        public Frog(string name, int age, string sex):base(name,age,sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }
        //metoda
        public override void MakeSound()
        {
            Console.WriteLine($"{this.name} Oac-Oac");
        }
        }
}
