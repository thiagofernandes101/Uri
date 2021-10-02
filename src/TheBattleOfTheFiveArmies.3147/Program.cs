using System;

namespace TheBattleOfTheFiveArmies._3147
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberOfArmies = Console.ReadLine().Split(' ');
            
            int humanArmy = Convert.ToInt32(numberOfArmies[0]);
            int elvesArmy = Convert.ToInt32(numberOfArmies[1]);
            int dwarvesArmy = Convert.ToInt32(numberOfArmies[2]);
            int orcsArmy = Convert.ToInt32(numberOfArmies[3]);
            int wargsArmy = Convert.ToInt32(numberOfArmies[4]);
            int eaglesArmy = Convert.ToInt32(numberOfArmies[5]);

            int goodSideArmy = humanArmy + elvesArmy + dwarvesArmy + eaglesArmy;
            int evilSideArmy = orcsArmy + wargsArmy;

            if (goodSideArmy >= evilSideArmy)
            {
                Console.WriteLine("Middle-earth is safe.");
            }
            else
            {
                Console.WriteLine("Sauron has returned.");
            }
        }
    }
}
;