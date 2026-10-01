using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOP_Arv.ChasZoo
{
    internal class Bear : Animal
    {
            
        public string FavouriteBerry { get; set; } // Unique property for the Bear. 
        public Bear(string name, int age, string colour, string sex, string food) : base(name, age, colour, sex, food) // Constructor for a new Bear, with FavouriteBerry set as Lingonberry.
        {
            FavouriteBerry = "Lingonberry";
        }
        public Bear() : base("Jenny", 17, "Brown", "Female", "Honey") // Hardcoded Bear into the subclass with a unique property.
        {
            FavouriteBerry = "Blueberry";
        }
        public override void Feed() // Method override from Animal-class with Bear-uniqueness. 
        {
            Console.WriteLine($"{Name} pushes down a tree-branch and grabs {Food}.");
        }
        public override void Pet() // Method override from Animal-class with Bear-uniqueness. 
        {
            Console.WriteLine($"{Name} loves to be petted, Thank you!");
        }
        public override void MakeSound() // Method override from Animal-class with Bear-uniqueness. 
        {
            Console.WriteLine($"{Name} roars! RAAAAAWRRRR!!!");

        }
        public void Fish() // The unique Bear method. 
        {
            Console.WriteLine($"{Name} jumps down in the river and chases an innocent fish!");
        }
    }

}
