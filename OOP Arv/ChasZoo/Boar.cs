using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOP_Arv.ChasZoo
{
    internal class Boar : Animal
    {
        public int TuskLength { get; set; } // Unique property for the Boar. 
        public Boar(string name, int age, string colour, string sex, string food) : base(name, age, colour, sex, food) // Constructor for a new Boar, with TuskLength set as 11.
        {
            TuskLength = 11;
        }
        public Boar() : base("Salty", 13, "Grey", "Male", "Chestnuts") // Hardcoded Boar into the subclass with a unique property.
        {
            TuskLength = 12;
        }
        public override void Feed() // Method override from Animal-class with Boar-uniqueness. 
        {
            Console.WriteLine($"{Name} digs in the ground searching for {Food}.");
        }
        public override void Pet() // Method override from Animal-class with Boar-uniqueness. 
        {
            Console.WriteLine($"{Name} likes to be petted, but only during daytime.");
        }
        public override void MakeSound() // Method override from Animal-class with Boar-uniqueness. 
        {
            Console.WriteLine($"{Name} grunts! GREEEE!");

        }
        public void Charge() // The unique Boar method. 
        {
            Console.WriteLine($"{Name} charges at the fence, AHHH!");
        }
    }
}
