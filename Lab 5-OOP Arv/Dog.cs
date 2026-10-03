using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Dog : Mammal
    {
        public string Breed { set; get; } = "Mixed";
        public Dog(string name, int age) : base(name, age)
        {
        }
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: Woof!");
        }
        public void Fetch()
        {
            Console.WriteLine($"{Name} hämtar bollen.");
        }
    }
}
