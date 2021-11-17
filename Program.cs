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
            first();
        }

        public static void gameTitle()
        {
            Console.WriteLine($@"
            
            █░█░█ █▀▀ █░░ █▀▀ █▀█ █▀▄▀█ █▀▀   ▀█▀ █▀█
            ▀▄▀▄▀ ██▄ █▄▄ █▄▄ █▄█ █░▀░█ ██▄   ░█░ █▄█
        
        
███╗░░░███╗░█████╗░██████╗░██╗░░░██╗███████╗███╗░░██╗████████╗██╗░░░██╗██████╗░███████╗
████╗░████║██╔══██╗██╔══██╗██║░░░██║██╔════╝████╗░██║╚══██╔══╝██║░░░██║██╔══██╗██╔════╝
██╔████╔██║███████║██████╔╝╚██╗░██╔╝█████╗░░██╔██╗██║░░░██║░░░██║░░░██║██████╔╝█████╗░░
██║╚██╔╝██║██╔══██║██╔══██╗░╚████╔╝░██╔══╝░░██║╚████║░░░██║░░░██║░░░██║██╔══██╗██╔══╝░░
██║░╚═╝░██║██║░░██║██║░░██║░░╚██╔╝░░███████╗██║░╚███║░░░██║░░░╚██████╔╝██║░░██║███████╗
╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚══════╝");
            Console.WriteLine("press 'Enter' to start");
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
            Console.WriteLine("Around him are a single tree and a bird.");
            Console.WriteLine("What will Marvin do?");
            Console.Write("1. Stare into the Sun");
            Console.Write("2. Build a Sand Castle");
            Console.Write("3. Kiss the Bird");
            Console.Write("4. Wither");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "Stare into the Sun" :
                {
                    Console.WriteLine("Marv stares into the Sun.");
                    break;
                }
            }
        }
    }
}
