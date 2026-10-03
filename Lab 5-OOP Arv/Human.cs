using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Human : Mammal
    {
        string Occupation { set; get; } = "Unknown";
        public Human(string name, int age) :base(name, age)
        {
                
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: Hej!");
        }
        public void Talk()
        {
            Console.WriteLine($"{Name} pratar.");
        }
    }
}
