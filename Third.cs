using System;

namespace Marventure
{
    class ThirdScene
    {
         public static void third()
        {
            string choice;

            Console.Clear();
            Console.WriteLine("Duke sits on his small patch of land in the water, barely big enough for his two feet.");
            Console.WriteLine("Marv notices the balance of guns that Duke boasts. A single oversized pistol in each hand.");
            Console.WriteLine("When did he get those?");
            Console.WriteLine("marv disregards them and remembers he's stuck on this island.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Kiss Duke on the mouth");
            Console.WriteLine("2. Get off of the island");
            Console.WriteLine("3. Show Duke your CDs");
            Console.WriteLine("4. Tickle Duke");
            Console.WriteLine("");
            Console.WriteLine("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "kiss duke on the mouth":
                case "kiss duke":
                {
                    Console.WriteLine("Aw. How charming. So sweet.");
                    Console.WriteLine("Maybe this island isn't so bad?");
                    Console.WriteLine("");
                    Console.WriteLine("SPOILER: (it is.)");
                    Console.WriteLine("Your bird friend is heartbroken.");
                    Console.ReadLine();
                    Console.Clear();
                    third();
                    break;
                }
                case "2":
                case "get off of the island":
                case "get off the island":
                {
                    Console.WriteLine("'Marv get off the island.'");
                    Console.WriteLine("");
                    Console.WriteLine("That's you. That's how stupid you sound. I have no clue what you want him to do here.");
                    Console.WriteLine("Pretty dumb.");
                    Console.ReadLine();
                    Console.Clear();
                    third();
                    break;
                }
                case "3":
                case "show duke your cds":
                case "show him your cds":
                {
                    if (BoolsList.gotCD == true)
                    {
                    Console.WriteLine("Marv retrieves his favorite CD from the chest and lifts it up to show Duke. Everyone likes this song.");
                    Console.WriteLine("Duke promptly unloads a clip into the CD, obliterating it in your hand.");
                    Console.WriteLine("");
                    Console.WriteLine("Yikes. Itchy trigger finger, huh? Guess he doesn't like fingers in his... anyway");
                    Console.WriteLine("Probably keep the CDs to yourself, hooligan.");
                    BoolsList.gotCD = false;
                    Console.ReadLine();
                    Console.Clear();
                    FourthScene.fourth();
                    break;
                    } else {
                    Console.WriteLine("What CD?");
                    BoolsList.gotCD = false;
                    Console.ReadLine();
                    Console.Clear();
                    FourthScene.fourth();
                    break;
                    }
                }
                case "4":
                case "tickle duke":
                {
                    Console.WriteLine("Marv attempts to give that rapscallion a tickle, that's sure to loosen him up.");
                    Console.WriteLine("");
                    Console.WriteLine("You absolute buffoon. That's Duke! Everyone knows that you can't tickle Duke.");
                    Console.WriteLine("Now you're trapped, attempting to tickle someone who isn't laughing.");
                    Console.WriteLine("Marv is now awkwardly stuffing his fingers into the Dukes armpits as Duke stares him down, unflinching.");
                    Console.WriteLine("Classic.");
                    Console.ReadLine();
                    Console.Clear();
                    FourthScene.fourth();
                    break;
                }
            }
        }
    }
}