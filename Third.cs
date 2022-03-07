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
            Console.WriteLine("Marv disregards them and remembers he's stuck on this island.");
            Console.WriteLine("");
            Console.WriteLine("A treasure chest has washed up on shore. Perhaps it could contain the key to Marv's escape?");
            Console.WriteLine("What could be inside?");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Kiss Duke on the mouth");
            Console.WriteLine("2. Get off of the island");
            Console.WriteLine("3. Check the treasure chest");
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
                    Console.WriteLine("You lean in for a big smoochums from Duke. He reciprocates the act of intimacy.");
                    Console.WriteLine("");
                    Console.WriteLine("Aw. How charming. So sweet.");
                    Console.WriteLine("Maybe this island isn't so bad?");
                    Console.WriteLine("");
                    Console.WriteLine("SPOILER: (it is.)");
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
                case "check the treasure chest":
                case "check the chest":
                case "check chest":
                case "check treasure chest":
                {
                    Console.WriteLine("Oh Marv, how sad.");
                    Console.WriteLine("");
                    Console.WriteLine("The chest is full of CDs. Upon listening to them, he is greeted with sounds less than perferable.");
                    Console.WriteLine("");
                    Console.WriteLine("The CDs are endless.");
                    Console.ReadLine();
                    Console.Clear();
                    third();
                    break;
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
                    Console.WriteLine("");
                    Console.WriteLine("Marv notcies that Duke has dropped a third pistol from... somewhere.");
                    Console.WriteLine("He figures it's best to leave it alone for now.");
                    Console.ReadLine();
                    Console.Clear();
                    FourthScene.fourth();
                    break;
                }
            }
        }
    }
}