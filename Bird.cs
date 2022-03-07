using System;

namespace Marventure
{
    class BirdScene
    {
        public static void bird()
        {
            string choice;
        if (BoolsList.birdAlive == true)
        {
            Console.Clear();
            Console.WriteLine("Marvin now has a bird friend.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Kiss the Bird");
            Console.WriteLine("2. Ride the Bird to Freedom");
            Console.WriteLine("3. KILL KILL KILL THE BIRD");
            Console.WriteLine("4. Ignore the Bird");
            Console.WriteLine("");
            Console.WriteLine("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();
        } else {
            Console.Clear();
            Console.WriteLine("Marvin stands over the corpse of a friend.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Kiss the Bird");
            Console.WriteLine("2. Ride the Bird to Freedom");
            Console.WriteLine("3. KILL KILL KILL THE BIRD");
            Console.WriteLine("4. Ignore the Bird");
            if (BoolsList.hasMagic == true)
            {
                Console.WriteLine("5. Revive the Bird");
            }
            Console.WriteLine("");
            Console.WriteLine("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();
        }
            switch (choice)
            {
                case "1":
                case "kiss the bird":
                case "kiss":
                {
                    if (BoolsList.birdAlive == true)
                    {
                    Console.WriteLine("Marvin, what are you thinking?.");
                    Console.WriteLine("You'd dare think to subject this poor bird to your lustful whims?.");
                    Console.WriteLine("");
                    Console.WriteLine("The bird narrowly avoids a smooch... for now.");
                    Console.ReadLine();
                    Console.Clear();
                    bird();
                    break;
                    } else {
                    Console.WriteLine("Marvin looks at the rotting bird with intent to kiss it.");
                    Console.WriteLine("Upon further consideration, he realizes that he probably shouldn't.");
                    Console.WriteLine("");
                    Console.WriteLine("The bird narrowly avoids a smooch... for now.");
                    Console.ReadLine();
                    Console.Clear();
                    bird();
                    break;
                    }
                }
                case "2":
                case "ride the bird to freedom":
                case "ride the bird":
                {
                    if (BoolsList.birdAlive == false)
                    {
                        Console.WriteLine("Marv you already killed him.");
                        Console.WriteLine("Stop playing with the dead Bird.");
                        Console.ReadLine();
                        Console.Clear();
                        bird();
                        break;

                    } else {

                        Console.WriteLine("Marv climbs onto his bird friend, ready to be free!");
                        Console.WriteLine("At Last! Freedom! Fly away Marv!");
                        Console.WriteLine("");
                        Console.WriteLine("Marvin, you are unintelligent. That poor bird could never hold your weight, I'm not sure what you expected.");
                        Console.WriteLine("");
                        Console.WriteLine("Your bird friend consideres itself crushed to death.");
                        BoolsList.birdAlive = false;
                        Console.ReadLine();
                        Console.Clear();
                        bird();
                        break;
                    }
                }
                case "3":
                case "kill the bird":
                case "kill":
                case "kill kill kill the bird":
                case "kill kill kill":
                {
                    if (BoolsList.birdAlive == true)
                    {
                    Console.WriteLine("Without thinking, Marvin sprints at the bird and swings at it before it can even move.");
                    Console.WriteLine("");
                    Console.WriteLine("Oh no.");
                    Console.WriteLine("");
                    Console.WriteLine("Marv has murdered the bird.");
                    BoolsList.birdAlive = false;
                    Console.ReadLine();
                    Console.Clear();
                    bird();
                    break;
                    } else {
                    Console.WriteLine("Marvin, you are sick.");
                    Console.WriteLine("The poor thing is already dead.");
                    Console.ReadLine();
                    Console.Clear();
                    bird();
                    break;
                }}
                case "4":
                case "ignore the bird":
                case "ignore":
                {
                    Console.WriteLine("Marvin Disregards the Bird entirely.");
                    Console.ReadLine();
                    Console.Clear();
                    IslandScene.island();
                    break;
                }
                case "5":
                case "revive the bird":
                case "revive":
                {
                    if (BoolsList.hasMagic == true)
                    {
                    Console.WriteLine("Marvin draws upon his arcane intellect and begins chanting something that not even I understand.");
                    Console.WriteLine("");
                    Console.WriteLine("The bird considers itself revived");
                    Console.ReadLine();
                    Console.Clear();
                    bird();
                    break;
                    } else {
                    Console.WriteLine("Marvin, what are you thinking?");
                    Console.WriteLine("That's not an option.");
                    Console.ReadLine();
                    Console.Clear();
                    bird();
                    break;
                    }
                }
            }
        }

         public static void birdToThird()
        {
            string choice;
        if (BoolsList.birdAlive == true)
        {
            Console.Clear();
            Console.WriteLine("Marvin now has a bird friend.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Kiss the Bird");
            Console.WriteLine("2. Ride the Bird to Freedom");
            Console.WriteLine("3. Explore the Island");
            Console.WriteLine("4. KILL KILL KILL THE BIRD");
            Console.WriteLine("");
            Console.WriteLine("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();
        } else {
            Console.Clear();
            Console.WriteLine("Marvin stands over the corpse of a friend.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Kiss the Bird");
            Console.WriteLine("2. Ride the Bird to Freedom");
            Console.WriteLine("3. Explore the Island");
            Console.WriteLine("4. KILL KILL KILL THE BIRD");
            if (BoolsList.hasMagic == true)
            {
                Console.WriteLine("5. Revive the Bird");
            }
            Console.WriteLine("");
            Console.WriteLine("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();
        }
            switch (choice)
            {
                case "1":
                case "kiss the bird":
                case "kiss":
                {
                    if (BoolsList.birdAlive == true)
                    {
                    Console.WriteLine("Marvin turns, setting his sights on a beaky smooch.");
                    Console.WriteLine("Alas, the bird has disappeared. Marv remains smoochless.");
                    Console.WriteLine("");
                    Console.WriteLine("Marv looks around and finds a walkway to his right.");
                    Console.WriteLine("Move quick Marv! Who knows what juicy goodies could be over there?");
                    Console.WriteLine("");
                    Console.WriteLine("Oh, wait nope. False alarm. It's just Duke. As you were.");
                    Console.ReadLine();
                    Console.Clear();
                    ThirdScene.third();
                    break;
                    } else {
                    Console.WriteLine("Marvin looks at the rotting bird with intent to kiss it.");
                    Console.WriteLine("Upon further consideration, he realizes that he probably shouldn't.");
                    Console.ReadLine();
                    Console.Clear();
                    birdToThird();
                    break;
                    }
                }
                case "2":
                case "ride the bird to freedom":
                case "ride the bird":
                {
                    if (BoolsList.birdAlive == false)
                    {
                        Console.WriteLine("Marv you already killed him.");
                        Console.WriteLine("Stop playing with the dead Bird.");
                        Console.ReadLine();
                        Console.Clear();
                        birdToThird();
                        break;

                    } else {

                        Console.WriteLine("Marv climbs onto his bird friend, ready to be free!");
                        Console.WriteLine("At Last! Freedom! Fly away Marv!");
                        Console.WriteLine("");
                        Console.WriteLine("Marvin, you are unintelligent. That poor bird could never hold your weight, I'm not sure what you expected.");
                        Console.WriteLine("");
                        Console.WriteLine("Your bird friend consideres itself crushed to death.");
                        BoolsList.birdAlive = false;
                        Console.ReadLine();
                        Console.Clear();
                        birdToThird();
                        break;
                    }
                }
                case "3":
                case "explore the island":
                case "explore":
                {
                    Console.WriteLine("Marv quickly checks his surroundings to find that the island is still perplexingly small.");
                    Console.WriteLine("He finds a walkway to his right.");
                    Console.WriteLine("Move quick Marv! Who knows what juicy goodies could be over there?");
                    Console.WriteLine("");
                    Console.WriteLine("Oh, wait nope. False alarm. It's just Duke. As you were.");
                    Console.ReadLine();
                    Console.Clear();
                    ThirdScene.third();
                    break;
                }
                case "4":
                case "kill the bird":
                case "kill":
                case "kill kill kill the bird":
                case "kill kill kill":
                {
                    if (BoolsList.birdAlive == true)
                    {
                    Console.WriteLine("Without thinking, Marvin sprints at the bird and swings at it before it can even move.");
                    Console.WriteLine("");
                    Console.WriteLine("Oh no.");
                    Console.WriteLine("");
                    Console.WriteLine("Marv has murdered the bird.");
                    BoolsList.birdAlive = false;
                    Console.ReadLine();
                    Console.Clear();
                    birdToThird();
                    break;
                    } else {
                    Console.WriteLine("Marvin, you are sick.");
                    Console.WriteLine("The poor thing is already dead.");
                    Console.ReadLine();
                    Console.Clear();
                    birdToThird();
                    break;
                }}
                case "5":
                case "revive the bird":
                case "revive":
                {
                    if (BoolsList.hasMagic == true)
                    {
                    Console.WriteLine("Marvin draws upon his arcane intellect and begins chanting something that not even I understand.");
                    Console.WriteLine("");
                    Console.WriteLine("The bird considers itself revived");
                    Console.ReadLine();
                    Console.Clear();
                    birdToThird();
                    break;
                    } else {
                    Console.WriteLine("Marvin, what are you thinking?");
                    Console.WriteLine("That's not an option.");
                    Console.ReadLine();
                    Console.Clear();
                    birdToThird();
                    break;
                    }
                }
            }
        }
    }
}