using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    internal abstract class Animal
    {
        public string Name { set; get; } = "Unknown";
        public int Age { set; get; } = 0;
        public double Weight { set; get; } = 0;
        public string  Gender { set; get; } = "Unknown";
        public string Species { set; get; } = "Unknown";
        public string Habitat { set; get; } = "Unknown";

        protected Animal(string name ,int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void MakeSound();
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} äter.");
        }
        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} sover.");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name} rör sig.");
        }
        
       
    }
}
