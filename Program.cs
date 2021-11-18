using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marventure
{
    class Program
    {
        public static bool eldritch = false;
        public static bool birdAlive = true;
        public static bool gotCD = false;
        public static bool hasLadder = false;
        public static bool hasFruit = false;
        public static bool hasAxe = false;
        public static bool hasWood = false;
        public static bool hasRocks = false;
        public static bool hasBoat = false;
        public static bool sandCastle = false;

        static void Main(string[] args) 
        {
            gameTitle();
            first();
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
            Console.WriteLine("1. Stare into the Sun");
            Console.WriteLine("2. Build a Sand Castle");
            Console.WriteLine("3. Kiss the Bird");
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
                    if (eldritch == true)
                {
                    Console.WriteLine("What sun?");
                    eldritch = true;
                    Console.ReadLine();
                    Console.Clear();
                    first();
                    break;
                } else {
                    Console.WriteLine("Marv stares into the Sun.");
                    Console.WriteLine("The Eldritch Horrors he sees are terrifying, and he is forever a changed man.");
                    Console.WriteLine("");
                    Console.WriteLine("He promptly forgets the interaction entirely.");
                    eldritch = true;
                    Console.ReadLine();
                    Console.Clear();
                    first();
                    break;
                }
                }
                case "2":
                case "build a sand castle":
                {
                    Console.WriteLine("Marv begins his architectural journey.");
                    Console.WriteLine("Who knew such a young man had an impressive inate ability for building grainy structures?");
                    Console.WriteLine("");
                    Console.WriteLine("The sand castle considers itself built.");
                    sandCastle = true;
                    Console.ReadLine();
                    Console.Clear();
                    first();
                    break;
                }
                case "3":
                case "kiss the bird":
                case "kiss":
                {
                    Console.WriteLine("Marv turns, setting his sights on a beaky smooch.");
                    Console.WriteLine("Unfortuneatly, the once visable bird has disappeared. Marv remains smoochless.");
                    Console.WriteLine("");
                    Console.WriteLine("A treasure chest has washed up on shore. Perhaps this chest could contain the key to his escape?");
                    Console.WriteLine("What could be inside?");
                    Console.ReadLine();
                    second();
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
                    gotCD = true;
                    Console.ReadLine();
                    Console.Clear();
                    second();
                    break;
                }
                case "2":
                case "ride the bird to freedom":
                case "ride the bird":
                {
                    if (eldritch == true)
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
                        birdAlive = false;
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
                    third();
                    break;
                }
            }
        }

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
                    Console.WriteLine("Marv retrieves his favorite CD from the chest and lifts it up to show Duke. Everyone likes this song.");
                    Console.WriteLine("Duke promptly unloads a clip into the CD, obliterating it in your hand.");
                    Console.WriteLine("");
                    Console.WriteLine("Yikes. Itchy trigger finger, huh? Guess he doesn't like fingers in his... anyway");
                    Console.WriteLine("Probably keep the CDs to yourself, hooligan.");
                    gotCD = false;
                    Console.ReadLine();
                    Console.Clear();
                    fourth();
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
                    Console.ReadLine();
                    Console.Clear();
                    fourth();
                    break;
                }
            }
        }

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
                    Console.WriteLine("Boy oh boy was it possible. Maybe this place should be named Love Island. Impressive");
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
                    island();
                    break;
                }
            }
        }

        public static void island()
        {
            string choice;

            Console.Clear();

            Console.WriteLine("Marvin needs to get off of this island now. He can't stay here. There is no food, and he is surrounded by salt water.");
            Console.WriteLine("Realistically, he couldn't be here for more than a few days before he dies. It's time to find a way off this island");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Go to the tree");
            Console.WriteLine("2. Go to the Shore");
            Console.WriteLine("3. Go to the chest");
            Console.WriteLine("4. Go to Duke");
            Console.WriteLine("");
            Console.WriteLine("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "go to the tree":
                case "tree":
                {
                    Console.WriteLine("Marvin makes his way to the tree.");
                    Console.ReadLine();
                    Console.Clear();
                    tree();
                    break;
                }
                case "2":
                case "go to the shore":
                case "shore":
                {
                    Console.WriteLine("Marvin makes his way to the shore.");
                    Console.ReadLine();
                    Console.Clear();
                    shore();
                    break;
                }
                case "3":
                case "go to the chest":
                case "chest":
                {
                    Console.WriteLine("Marvin makes his way to the chest.");
                    Console.ReadLine();
                    Console.Clear();
                    chest();
                    break;
                }
                case "4":
                case "go to duke":
                case "duke":
                {
                    Console.WriteLine("Marvin makes his way to Duke.");
                    Console.ReadLine();
                    Console.Clear();
                    duke();
                    break;
                }
            }
        }

        public static void tree()
        {
            string choice;

            Console.Clear();

            Console.WriteLine("Marvin stares at the tree. It remains just a tree.");
            Console.WriteLine("Big leaves hang from the top, creating a spot of shade.");
            Console.WriteLine("Marv sees some fruit hanging pretty high up on the tree. He realizes his hunger once he sees the fruit.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Try to get the fruit");
            Console.WriteLine("2. Try to cut the tree down");
            Console.WriteLine("3. Hide in the tree");
            Console.WriteLine("4. Worship the tree");
            Console.WriteLine("5. Ignore the tree");
            Console.WriteLine("");
            Console.WriteLine("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "try to get the fruit":
                case "fruit":
                {
                    if (hasLadder == true)
                    {
                        Console.WriteLine("Marvin grabs a fruit.");
                        hasFruit = true;
                        Console.ReadLine();
                        Console.Clear();
                        tree();
                        break;
                    } else if (hasFruit == true) {
                        Console.WriteLine("Marvin already has the fruit.");
                        Console.ReadLine();
                        Console.Clear();
                        tree();
                        break;
                    } else {
                        Console.WriteLine("Marvin stares at the fruit, his hunger growing with each second.");
                        Console.WriteLine("He decides it's best not to look at it, out of sight out of mind.");
                        Console.ReadLine();
                        Console.Clear();
                        tree();
                        break;
                    }
                }
                case "2":
                case "try to cut the tree down":
                {
                    if (hasAxe == true)
                    {
                        Console.WriteLine("Marvin cuts down the tree and obtains a multitude of wood and leaves.");
                        hasWood = true;
                        Console.ReadLine();
                        Console.Clear();
                        tree();
                        break;
                    } else if (hasAxe == true) {
                        Console.WriteLine("Marvin already cut down the tree.");
                        Console.ReadLine();
                        Console.Clear();
                        tree();
                        break;
                    } else {
                        Console.WriteLine("Marvin Has nothing to cut the tree down with.");
                        Console.WriteLine("He ponders punching it until it gives him little pieces of wood, but what would Marv do with them?.");
                        Console.WriteLine("All he'd have are woodchips and broken knuckles.");
                        Console.ReadLine();
                        Console.Clear();
                        tree();
                        break;
                    }
                }
                case "3":
                case "hide in the tree":
                {
                    Console.WriteLine("What does this even mean.");
                    Console.WriteLine("Honestly, sometimes you say some stupid stuff.");
                    Console.WriteLine("Marvin will procceed to avoid doing that.");
                    Console.ReadLine();
                    Console.Clear();
                    tree();
                    break;
                }
                case "4":
                case "worship the tree":
                case "worship":
                {
                    Console.WriteLine("Marvin kneels down next to the tree.");
                    Console.WriteLine("He begins to worship the tree with praises and song.");
                    Console.WriteLine("The worshipping goes on for days.");
                    Console.WriteLine("");
                    Console.WriteLine("Eventually, he realizes he is no longer on the island.");
                    Console.ReadLine();
                    Console.Clear();
                    heaven();
                    break;
                }
                case "5":
                case "ignore the tree":
                case "ignore":
                {
                    Console.WriteLine("Marvin disregards the tree entirely.");
                    Console.ReadLine();
                    Console.Clear();
                    island();
                    break;
                }
            }  
        }

        public static void shore()
        {
            string choice;

            Console.Clear();

            Console.WriteLine("Marvin moves over to the shore. He notices a collection of small, sharp rocks just before the shoreline.");
            Console.WriteLine("In front of him lies a sea so big he cannot see the whole thing.");
            Console.WriteLine("The water looks excruciatingly cold.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Pick up some rocks");
            Console.WriteLine("2. Go for a swim");
            Console.WriteLine("3. Build a sand castle");
            Console.WriteLine("4. Ignore the shore");
            Console.WriteLine("");
            Console.WriteLine("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "pick up some rocks":
                case "pick up rocks":
                {
                    if (hasRocks == !true)
                    {
                    Console.WriteLine("Marvin bends down and picks up a few sharp rocks.");
                    Console.WriteLine("What might he need these for?");
                    Console.WriteLine("");
                    Console.WriteLine("The rocks consider themselves picked up");
                    hasRocks = true;
                    Console.ReadLine();
                    Console.Clear();
                    shore();
                    break;
                    } else {
                    Console.WriteLine("Marvin already picked up those rocks.");
                    Console.ReadLine();
                    Console.Clear();
                    shore();
                    break;
                    }
                }
                case "2":
                case "go for a swim":
                case "swim":
                case "go swim":
                case "go swimming":
                {
                    Console.WriteLine("Marvin finds himself drawn to the salty water.");
                    Console.WriteLine("Unfortunately, Marv never learned how to swim.");
                    Console.WriteLine("This does not stop him from dipping his toes in the water.");
                    Console.WriteLine("");
                    Console.WriteLine("The water is unpleasantly cold, and he immediatly retracts back onto the warm sand.");
                    Console.ReadLine();
                    Console.Clear();
                    shore();
                    break;
                }
                case "3":
                case "build a sand castle":
                case "build a castle":
                {
                    Console.WriteLine("Marvin is overtaken by the need to suddenly perform acts of architectural wonder.");
                    Console.WriteLine("As he grabs wet sand, he builds quite a beautiful home.");
                    Console.WriteLine("He hopes one day to live in such a nice place.");
                    Console.WriteLine("");
                    Console.WriteLine("The sand castle considers itself built.");
                    sandCastle = true;
                    Console.ReadLine();
                    Console.Clear();
                    shore();
                    break;
                }
                case "4":
                case "ignore the shore":
                case "ignore shore":
                {
                    Console.WriteLine("Marvin disregards the shore entirely.");
                    Console.ReadLine();
                    Console.Clear();
                    island();
                    break;
                }
            }
        }

        public static void chest()
        {
            string choice;

            Console.Clear();

            Console.WriteLine("Marvin stares at the tree. It remains just a tree.");
            Console.WriteLine("Big leaves hang from the top, creating a spot of shade.");
            Console.WriteLine("Marv sees some fruit hanging pretty high up on the tree. He realizes his hunger once he sees the fruit.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
        }

        public static void duke()
        {
            string choice;

            Console.Clear();

            Console.WriteLine("Marvin stares at the tree. It remains just a tree.");
            Console.WriteLine("Big leaves hang from the top, creating a spot of shade.");
            Console.WriteLine("Marv sees some fruit hanging pretty high up on the tree. He realizes his hunger once he sees the fruit.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
        }
        public static void heaven()
        {
            string choice;

            Console.Clear();

            Console.WriteLine("Marvin stares at the tree. It remains just a tree.");
            Console.WriteLine("Big leaves hang from the top, creating a spot of shade.");
            Console.WriteLine("Marv sees some fruit hanging pretty high up on the tree. He realizes his hunger once he sees the fruit.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
        }

        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine($@"
            Marv has died

            ▀█▀ █▀█ █▄█   ▄▀█ █▀▀ ▄▀█ █ █▄░█   ▀ ▀▄
            ░█░ █▀▄ ░█░   █▀█ █▄█ █▀█ █ █░▀█   ▄ ▄▀");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }
}