using System;

namespace Marventure
{
    class FourthScene
    {
        public static void fourth()
        {
            string choice;

            Console.Clear();

            Console.WriteLine("Unfortunately, Duke is not amused with the tickling. Is there even anything he can do about that?");
            Console.WriteLine("Marv wonders nothing, as his mind is an empty void.");
            Console.WriteLine("");
            Console.WriteLine("Is there anything Marv can do to save this awkward situation?");
            Console.WriteLine("");
            Console.WriteLine("1. Do Nothing");
            Console.WriteLine("2. Do a little dance");
            Console.WriteLine("3. Ask Duke who he is");
            Console.WriteLine("4. Get on with the game");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
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
                case "2":
                case "do a little dance":
                case "dance":
                {
                    Console.WriteLine("Marv begins to throw it back and bring it around town.");
                    Console.WriteLine("You have no idea where he learned these obscene moves.");
                    Console.ReadLine();
                    Console.Clear();
                    fourth();
                    break;
                }
                case "3":
                case "ask duke who he is":
                {
                    Console.WriteLine("Marv begins to ask Duke who he is, but then remembers exactly who is, and realizes what a stupid question that would be.");
                    Console.WriteLine("Why even suggest that?");
                    Console.ReadLine();
                    Console.Clear();
                    fourth();
                    break;
                }
                case "4":
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