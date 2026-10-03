using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Chihuahua : Dog
    {
        public bool IsSmall { set; get; } = true;
        public Chihuahua(string name, int age) : base(name, age)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: Yap yap!");
        }
        public void BarkLoudly()
        {
            Console.WriteLine($"{Name} skäller högt.");
        }
    }
}
