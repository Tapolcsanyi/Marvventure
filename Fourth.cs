using System;

namespace Marventure
{
    class FourthScene
    {
        public static void fourth()
        {
            string choice;

            Console.Clear();

            Console.WriteLine("Unfortunately, Duke is not amused. Is there even anything you can do about that?");
            Console.WriteLine("Marv wonders nothing, as his mind is an empty void.");
            Console.WriteLine("");
            Console.WriteLine("Is there anything else you'd like Marvin to do before actually trying to leave the island?");
            Console.WriteLine("");
            Console.WriteLine("1. Slap Duke's Booty");
            Console.WriteLine("2. Do Nothing");
            Console.WriteLine("3. Grab the gun");
            Console.WriteLine("4. Ask Duke who he is");
            Console.WriteLine("5. Get on with the game");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "slap duke's booty":
                case "slap dukes booty":
                {
                    Console.WriteLine("Marv slaps Duke's booty as seductively as possible.");
                    Console.WriteLine("");
                    Console.WriteLine("Boy oh boy was it possible. Maybe this place should be named Love Island.");
                    Console.WriteLine("Marvin leaves an impressive hand print upon Duke's cheek.");
                    Console.WriteLine("");
                    Console.WriteLine("Duke considers his booty slapped");
                    Console.ReadLine();
                    Console.Clear();
                    fourth();
                    break;
                }
                case "2":
                case "do nothing":
                case "nothing":
                {
                    Console.WriteLine("Marvin procceeds to do nothing.");
                    Console.ReadLine();
                    Console.WriteLine("Absolutely nothing.");
                    Console.ReadLine();
                    Console.WriteLine("...");
                    Console.ReadLine();
                    Console.WriteLine("Ok that's enough nothing.");
                    Console.ReadLine();
                    Console.Clear();
                    fourth();
                    break;
                }
                case "3":
                case "grab the gun":
                {
                    Console.WriteLine("It seems when you were tickkling Duke, he dropped a gun from... somewhere.");
                    Console.WriteLine("You reach to pick it up.");
                    Console.WriteLine("");
                    Console.WriteLine("Woah there partner. Duke raises his guns to show he's not messing around. At least, that's what you assume.");
                    Console.WriteLine("You decide maybe it's best to not mess with Duke's gun.");
                    Console.ReadLine();
                    Console.Clear();
                    fourth();
                    break;
                }
                case "4":
                case "ask duke who he is":
                {
                    Console.WriteLine("Marv begins to ask Duke who he is, but then remembers exactly who is, and realizes what a stupid question that would be.");
                    Console.WriteLine("Why even suggest that?");
                    Console.ReadLine();
                    Console.Clear();
                    fourth();
                    break;
                }
                case "5":
                case "get on with the game":
                case "get on with it":
                {
                    Console.WriteLine("Marv decides to get on with it.");
                    Console.WriteLine("He can't stay here forever.");
                    Console.ReadLine();
                    Console.Clear();
                    IslandScene.island();
                    break;
                }
            }
        }
    }
}