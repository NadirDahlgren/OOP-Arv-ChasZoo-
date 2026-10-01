using OOP_Arv.ChasZoo;
namespace OOP_Arv.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INTRO 

            List<Animal> chasZoo = new List<Animal>(); // List that stores all Animals

            Boar salty = new Boar(); // Created a new boar class and added it to the Animal-list. 
            chasZoo.Add(salty);

            Bear jenny = new Bear(); // Created a new bear class and added it to the Animal-list. 
            chasZoo.Add(jenny);

            Bat greg = new Bat(); // Bat + Two subclasses under Bat.
            chasZoo.Add(greg); // Created a new bat class and added it to the Animal-list. 

            EasternRedBat habanero = new EasternRedBat();
            chasZoo.Add(habanero);

            SilverBat slimShady = new SilverBat();
            chasZoo.Add(slimShady);

            // MENU

            Console.WriteLine(
                "Welcome to Chas Zoo!\n" +
                "List of all animals: \n" +
                "We present our animals: \n");

            foreach (Animal djur in chasZoo) // Foreach-iteration for every animal in the list. 
            {
                djur.MakeSound();
            }

            Console.WriteLine("\nThat's all folks! Thank you for paying a visit!");

        }
    }
}
