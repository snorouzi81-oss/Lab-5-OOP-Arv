using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Snake : Reptile
    {
        public bool IsVenomous { set; get; } = false;

        public Snake(string name, int age) : base(name, age)
        {
                
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} väser.");
        }
        public void Slither()
        {
            Console.WriteLine($"{Name} ringlar sig fram.");
        }
    }
}
