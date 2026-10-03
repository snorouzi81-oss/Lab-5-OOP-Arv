using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Bulldog : Dog
    {
        public bool HasWrinkles { set; get; } = true;
        public Bulldog(string name,int age) :base (name ,age)
        {
                
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: Woof! Woof!");
        }
        public void Snore()
        {
            Console.WriteLine($"{Name} snarkar.");
        }

    }
}
