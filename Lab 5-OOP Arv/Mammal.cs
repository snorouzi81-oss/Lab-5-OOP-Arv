using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal abstract class Mammal : Animal
    {
        public bool HasFur { set; get; } = true;
        protected Mammal(string name, int age) : base(name, age)
        {
                
        }
    }
}
