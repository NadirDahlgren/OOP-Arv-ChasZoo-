using System;

namespace OOP_Arv.ChasZoo
{
    internal class EasternRedBat : Bat
    {
        public TimeOnly EarlyHunter { get; set; }
        public EasternRedBat() : base("Habanero", 14, "Blood Red", "Female", "Moths")
        {
            EarlyHunter = new TimeOnly(5, 30);
        }
        public void MorningBat()
        {
            Console.WriteLine($"{Name} starts hunting at: {EarlyHunter:HH:mm}. Watch out moths!");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} frightens everyone with the colour of {Colour}! SCREEECH!");
        }
    }
}
