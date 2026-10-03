using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal abstract class Reptile : Animal
    {
        public bool IsColdBlooded { set; get; } = true;
        protected Reptile(string name, int age) : base (name,age)
        {
                
        }
    }
}
