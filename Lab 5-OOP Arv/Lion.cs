using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Lion : Mammal
    {
        string ManeSize { set; get; } = "Stor";
        public Lion(string name, int age) : base(name, age)
        {

        }
        public Lion(string name, int age, string maneSize) : base(name, age)
        {
            ManeSize = maneSize;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: Roar!");
        }
        public void Hunt()
        {
            Console.WriteLine($"{Name} jagar efter mat.");
        }
    }
}
