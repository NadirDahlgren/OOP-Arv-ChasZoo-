using System;

namespace OOP_Arv.ChasZoo
{
    internal class Bat : Animal
    {
        public int SleepHours { get; set; } // Unique property for the bat. 
        public Bat (string name, int age, string colour, string sex, string food) : base(name, age, colour, sex, food) // Constructor for a new bat, with SleepHours 20 set as default.
        {
            SleepHours = 20;
        }
        public Bat() : base("Greg", 8, "Black" , "Male", "Insects") // Hardcoded bat into the subclass with a unique property.
        {
            SleepHours = 17;
        }
        public override void Feed() // Method override from Animal-class with Bat-uniqueness. 
        {
            Console.WriteLine($"{Name} eats a whole bowl of {Food}.");
        }
        public override void Pet() // Method override from Animal-class with Bat-uniqueness. 
        {
            Console.WriteLine($"{Name} hates being touched! Leave me alone!");
        }
        public override void MakeSound() // Method override from Animal-class with Bat-uniqueness. 
        {
            Console.WriteLine($"{Name} squeaks! SQUEAAAAK!!!");

        }
        public void Fly() // The unique Bat method. 
        {
            Console.WriteLine($"{Name} flaps around with the wings! Swoooooosh!");
        }
    }
}
