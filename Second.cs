using System;

namespace Marventure
{
    class SecondScene
    {
        public static void second()
        {
            string choice;

            Console.Clear();
            Console.WriteLine("Disregarding the chest, Marvin looks for the bird, as he is yet again overtaken by the need of beaky smoochin'.");
            Console.WriteLine("He finds the bird behind the tree, and they have a conversation that went like this.");
            Console.WriteLine("");
            Console.WriteLine("Bird:...");
            Console.WriteLine("");
            Console.WriteLine("Looks like birds still can't talk.");
            Console.WriteLine("The bird does, however, direct Marv's attention to the quickly setting sun with an ostentatious, and to be frank, seductive swish of the tail.");
            Console.WriteLine("Marv better get moving");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Open the Treasure Chest");
            Console.WriteLine("2. Ride the Bird to Freedom");
            Console.WriteLine("3. Drown");
            Console.WriteLine("4. Explore the Island");
            Console.WriteLine("");
            Console.WriteLine("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "open the treasure chest":
                case "open":
                {
                    Console.WriteLine("Oh Marv, how sad.");
                    Console.WriteLine("");
                    Console.WriteLine("Marv opens the chest to discover it is full of CDs. Upon listening to said CDs, he is greeted with sounds that are less than preferable.");
                    Console.WriteLine("");
                    Console.WriteLine("He listens to the CDs all night.");
                    BoolsList.gotCD = true;
                    Console.ReadLine();
                    Console.Clear();
                    second();
                    break;
                }
                case "2":
                case "ride the bird to freedom":
                case "ride the bird":
                {
                    if (BoolsList.eldritch == true)
                    {
                        Console.WriteLine("Marv climbs onto his bird friend, ready to be free!");
                        Console.WriteLine("At Last! Freedom! Fly away Marv!");
                        Console.WriteLine("");
                        Console.WriteLine("Marvin, you are unintelligent. That poor bird could never hold your weight, I'm not sure what you expected.");
                        Console.WriteLine("Your bird friend consideres itself crushed to death.");
                        Console.WriteLine("");
                        Console.WriteLine("Luckily, you have recieved a multitude of ancient wisdom from a certain group of impercemptible beings.");
                        Console.WriteLine("They help you bring back your bird friend.");
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;

                    } else {

                        Console.WriteLine("Marv climbs onto his bird friend, ready to be free!");
                        Console.WriteLine("At Last! Freedom! Fly away Marv!");
                        Console.WriteLine("");
                        Console.WriteLine("Marvin, you are unintelligent. That poor bird could never hold your weight, I'm not sure what you expected.");
                        Console.WriteLine("Your bird friend consideres itself crushed to death.");
                        BoolsList.birdAlive = false;
                        Console.ReadLine();
                        Console.Clear();
                        second();
                        break;
                    }
                }
                case "3":
                case "Drown":
                {
                    Console.WriteLine("Marvin, what are you thinking?");
                    Console.WriteLine("Surely the allure of the salty water is not as strong as your will to live, right Marv?");
                    Console.WriteLine("");
                    Console.WriteLine("Marvin ponders this decision for a bit longer than most sane people. Unfortunately, he sees this as a way off the island.");
                    Console.WriteLine("Marv decides against drowning.");
                    Console.ReadLine();
                    Console.Clear();
                    second();
                    break;
                }
                case "4":
                case "explore the island":
                case "explore":
                {
                    Console.WriteLine("Marv quickly checks his surroundings to find that the island is still perplexingly small.");
                    Console.WriteLine("He finds some small land formations in the water, big enough for his feet.");
                    Console.WriteLine("Move quick Marv! Who knows what juicy goodies could be over there?");
                    Console.WriteLine("");
                    Console.WriteLine("Oh, wait nope. False alarm. It's just Duke. As you were.");
                    Console.ReadLine();
                    Console.Clear();
                    ThirdScene.third();
                    break;
                }
            }
        }
    }
}