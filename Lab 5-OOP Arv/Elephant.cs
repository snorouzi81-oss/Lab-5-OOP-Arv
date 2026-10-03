using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal class Elephant : Mammal
    {
        public double TrunkLength { set; get; } = 0.2;
        public Elephant(string name, int age) : base (name ,age)
        {
                
        }
        public Elephant(string name, int age , double trunkLength) : base(name, age)
        {
            TrunkLength = trunkLength;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} säger: Trumpet!");
        }
        public void SprayWater()
        {
            Console.WriteLine($"{Name} sprutar vatten med sin snabel.");
        }
    }
}
