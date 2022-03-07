using System;

namespace Marventure
{
    class FoodScene
    {
        public static void food()
        {
            if (BoolsList.openedChain == false)
            {
            Console.Clear();
            Console.WriteLine("Marvin opens the first establishment in his booming new food chain.");
            Console.WriteLine("");
            Console.WriteLine("Unfortunately, not many people know of the island restaurant. He Doesn't receive a single customer for 3 days.");
            Console.WriteLine("");
            Console.WriteLine("Marv is forced to close his doors. Until next time.");
            Console.ReadLine();
            Console.Clear();
            Program.first();
            } else {
            Console.Clear();
            Console.WriteLine("Marvin already tried this. It didn't work out.");
            Console.ReadLine();
            Console.Clear();
            Program.first();
            }
        }
    }
}