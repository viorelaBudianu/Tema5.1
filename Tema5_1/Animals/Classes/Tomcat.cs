using System;

namespace Animals
{
    public class Tomcat : Cat
    {
        // Constructor
        public Tomcat(string name, int age, string sex, string breed)
            : base(name, age, "male", breed)
        {

        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("I'm a tomcat");
        }
    }
}
