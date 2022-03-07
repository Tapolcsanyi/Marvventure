using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marventure
{
    class Program
    {
        static void Main(string[] args) 
        {
            gameTitle();
        }

        public static void gameTitle()
        {
            Console.Clear();
            Console.WriteLine($@"
            
            █░█░█ █▀▀ █░░ █▀▀ █▀█ █▀▄▀█ █▀▀   ▀█▀ █▀█
            ▀▄▀▄▀ ██▄ █▄▄ █▄▄ █▄█ █░▀░█ ██▄   ░█░ █▄█
        
        
███╗░░░███╗░█████╗░██████╗░██╗░░░██╗███████╗███╗░░██╗████████╗██╗░░░██╗██████╗░███████╗
████╗░████║██╔══██╗██╔══██╗██║░░░██║██╔════╝████╗░██║╚══██╔══╝██║░░░██║██╔══██╗██╔════╝
██╔████╔██║███████║██████╔╝╚██╗░██╔╝█████╗░░██╔██╗██║░░░██║░░░██║░░░██║██████╔╝█████╗░░
██║╚██╔╝██║██╔══██║██╔══██╗░╚████╔╝░██╔══╝░░██║╚████║░░░██║░░░██║░░░██║██╔══██╗██╔══╝░░
██║░╚═╝░██║██║░░██║██║░░██║░░╚██╔╝░░███████╗██║░╚███║░░░██║░░░╚██████╔╝██║░░██║███████╗
╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚══════╝");
            Console.WriteLine("press 'Enter' to start and to move forward");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            string choice;

            Console.WriteLine("Marvin sits on his beautiful island. How relaxing.");
            Console.WriteLine("...");
            Console.WriteLine("");
            Console.WriteLine("On Second thought, it's not very beautiful, and it's far from relaxing.");
            Console.WriteLine("To be honest, it's pretty awful. Marv hates it here.");
            Console.WriteLine("");
            Console.WriteLine("Around him are a single tree and a bird. The island is perplexingly small.");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Stare at the Sun");
            Console.WriteLine("2. Start a fast food chain");
            Console.WriteLine("3. Go to the Bird");
            Console.WriteLine("4. Wither");
            Console.WriteLine("");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "stare into the sun":
                case "stare":
                {
                    if (BoolsList.eldritch == true)
                {
                    Console.WriteLine("What sun?");
                    BoolsList.eldritch = true;
                    Console.ReadLine();
                    Console.Clear();
                    first();
                    break;
                } else {
                    Console.WriteLine("Marv stares into the Sun.");
                    Console.WriteLine("The Eldritch Horrors he sees are terrifying, and he is forever a changed man.");
                    Console.WriteLine("");
                    Console.WriteLine("He promptly forgets the interaction entirely.");
                    BoolsList.eldritch = true;
                    Console.ReadLine();
                    Console.Clear();
                    first();
                    break;
                }}
                case "2":
                case "start a fast food chain":
                case "food chain":
                case "start a chain":
                case "food":
                {
                    if (BoolsList.openedChain == false)
                    {
                    Console.Clear();
                    Console.WriteLine("Marvin opens the first establishment in his booming new food chain.");
                    Console.WriteLine("");
                    Console.WriteLine("Unfortunately, not many people know of the island restaurant. He Doesn't receive a single customer for 3 days.");
                    Console.WriteLine("");
                    Console.WriteLine("Marv is forced to close his doors. Until next time.");
                    BoolsList.openedChain = true;
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
                    Console.ReadLine();
                    Console.Clear();
                    FoodScene.food();
                    break;
                }
                case "3":
                case "go to the bird":
                case "bird":
                {
                    Console.WriteLine("Marvin makes his way to the bird.");
                    Console.ReadLine();
                    Console.Clear();
                    BirdScene.birdToThird();
                    break;
                }
                case "4":
                case "wither":
                {
                    Console.WriteLine("Marvin decides that he has lived a good life. He no longer worries about the future.");
                    Console.WriteLine("He breaks away from the existential dread that was tying him to find a way off of the island.");
                    Console.WriteLine("He finds a comfortable spot near the tree, lies down, and begins to think.");
                    Console.WriteLine("Marv thinks of his family back home. His wife and two kids. His Mom and his Dad.");
                    Console.WriteLine("He thinks of his friends. His three best friends who have been with him since the beginning.");
                    Console.WriteLine("He thinks of his coworkers. There were times when he hated his job, but now he was thankful for the experiences.");
                    Console.WriteLine("He thinks of the times that he shared with everyone, and how he is glad that his life had turned out how it had.");
                    Console.WriteLine("");
                    Console.WriteLine("With each passing thought, the sea level rises more and more. Marv is unaware of the years and years that he has spent on the island.");
                    Console.WriteLine("Marv no longer needs to eat or drink or sleep. He has already taken his final breath.");
                    Console.WriteLine("...");
                    Console.ReadLine();
                    gameOver();
                    break;
                }
            }
        }

        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine($@"
            Marvin has died...

            ▀█▀ █▀█ █▄█   ▄▀█ █▀▀ ▄▀█ █ █▄░█   ▀ ▀▄
            ░█░ █▀▄ ░█░   █▀█ █▄█ █▀█ █ █░▀█   ▄ ▄▀");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }
}