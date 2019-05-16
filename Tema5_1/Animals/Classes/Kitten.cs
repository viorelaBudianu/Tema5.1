using System;

namespace Animals
{
    public class Kitten:Cat
    {
        // Constructor
        public Kitten(string name, int age, string sex, string breed)
            : base(name, age, "female", breed)
        {

        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("I'm a kitten");
        }
    }
}
