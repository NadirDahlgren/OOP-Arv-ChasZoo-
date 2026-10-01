using System;

namespace OOP_Arv.ChasZoo
{
    internal class SilverBat : Bat
    {
        public bool CanSeeInTheDark { get; set; }
        public SilverBat() : base("SlimShady", 13, "Silver", "Male", "Butterflies")
        {
            CanSeeInTheDark = true;
        }
        public void NightVision()
        {
            if (CanSeeInTheDark)
            {
                Console.WriteLine($"{Name} swooshes around in the dark with nightvision! Amazing!");
            }
            else
            {
                Console.WriteLine($"{Name} flies around in daytime, with a silver coloured fur.");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} screeches!");
        }
    }
}
