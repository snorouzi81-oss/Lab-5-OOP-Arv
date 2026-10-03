using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal abstract class Bird : Animal
    {
        public bool CanFly { set; get; } = true;
        protected Bird(string name, int age) : base (name, age)
        {
                
        }

    }
}
