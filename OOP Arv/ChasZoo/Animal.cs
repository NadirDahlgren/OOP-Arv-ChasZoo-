using System;
using OOP_Arv.ChasZoo;

namespace OOP_Arv.ChasZoo
{

    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Colour { get; set; }
        public string Sex { get; set; }
        public string Food { get; set; }

        public Animal(string name, int age, string colour, string sex, string food)
        {
            Name = name;
            Age = age;
            Colour = colour;
            Sex = sex;
            Food = food;
        }

        public abstract void Feed();
        public abstract void Pet();
        public abstract void MakeSound();
    }

}