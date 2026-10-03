using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Penguin : Bird
    {
        public bool CanSwim { set; get; } = true;
        public Penguin(string name, int age) : base(name, age)
        {
            CanFly = false;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: Squawk!");
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} simmar i vattnet.");
        }
    }
}
