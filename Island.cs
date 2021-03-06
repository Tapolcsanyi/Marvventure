using System;

namespace Marventure
{
    class IslandScene
    {
        public static void island()
        {
            string choice;

            Console.Clear();

            Console.WriteLine("Marvin needs to get off of this island now. He can't stay here. There is no food, and he is surrounded by salt water.");
            Console.WriteLine("Realistically, he couldn't be here for more than a few days before he dies. It's time to find a way off this island.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Go to the tree");
            Console.WriteLine("2. Go to the Shore");
            Console.WriteLine("3. Go to the chest");
            Console.WriteLine("4. Go to Duke");
            Console.WriteLine("5. Go to the bird");
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
                case "5":
                case "go to the bird":
                case "bird":
                {
                    Console.WriteLine("Marvin makes his way to the Bird.");
                    Console.ReadLine();
                    Console.Clear();
                    BirdScene.bird();
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
                    if (BoolsList.hasLadder == true)
                    {
                        Console.WriteLine("Marvin grabs a fruit.");
                        BoolsList.hasFruit = true;
                        Console.ReadLine();
                        Console.Clear();
                        tree();
                        break;
                    } else if (BoolsList.hasFruit == true) {
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
                    if (BoolsList.hasAxe == true)
                    {
                        Console.WriteLine("Marvin cuts down the tree and obtains a multitude of wood and leaves.");
                        BoolsList.hasWood = true;
                        Console.ReadLine();
                        Console.Clear();
                        tree();
                        break;
                    } else if (BoolsList.hasAxe == true) {
                        Console.WriteLine("Marvin already cut down the tree.");
                        Console.ReadLine();
                        Console.Clear();
                        tree();
                        break;
                    } else if (BoolsList.hasStick == false){
                        Console.WriteLine("Marvin Has nothing to cut the tree down with.");
                        Console.WriteLine("He ponders punching it until it gives him little pieces of wood, but what would Marv do with them?.");
                        Console.WriteLine("All he'd have are woodchips and broken knuckles.");
                        Console.WriteLine("");
                        Console.WriteLine("Marvin does, however, acquire some sticks from the base of the tree.");
                        BoolsList.hasStick = true;
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
                    if (BoolsList.hasMagic == !true)
                    {
                    Console.WriteLine("Marvin kneels down next to the tree.");
                    Console.WriteLine("He begins to worship the tree with praises and song.");
                    Console.WriteLine("The worshipping goes on for days.");
                    Console.WriteLine("");
                    Console.WriteLine("Eventually, he realizes he is no longer on the island.");
                    Console.ReadLine();
                    Console.Clear();
                    HeavenScene.goddess();
                    break;
                    } else {
                    Console.WriteLine("Marvin kneels down next to the tree.");
                    Console.WriteLine("He begins to worship the tree with praises and song.");
                    Console.WriteLine("The worshipping goes on for days.");
                    Console.WriteLine("");
                    Console.WriteLine("Eventually, he realizes he is no longer on the island.");
                    Console.ReadLine();
                    Console.Clear();
                    HeavenScene.heaven();
                    break;
                    }
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

            Console.WriteLine("Marvin is right by the water. He notices a collection of small, sharp rocks just before the shoreline.");
            Console.WriteLine("In front of him lies a sea so big he cannot see the whole thing.");
            Console.WriteLine("The water looks excruciatingly cold.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Pick up some rocks");
            Console.WriteLine("2. Drown");
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
                    if (BoolsList.hasRocks == !true)
                    {
                    Console.WriteLine("Marvin bends down and picks up a few sharp rocks.");
                    Console.WriteLine("What might he need these for?");
                    Console.WriteLine("");
                    Console.WriteLine("The rocks consider themselves picked up");
                    BoolsList.hasRocks = true;
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
                case "drown":
                case "swim":
                case "go swim":
                case "go swimming":
                {
                    Console.WriteLine("Marvin, what are you thinking?");
                    Console.WriteLine("Surely the allure of the salty water is not as strong as your will to live, right Marv?");
                    Console.WriteLine("");
                    Console.WriteLine("Marvin ponders this decision for a bit longer than most sane people. Unfortunately, he sees this as a way off the island.");
                    Console.WriteLine("Marv decides against drowning.");
                    Console.ReadLine();
                    Console.Clear();
                    shore();
                    break;
                }
                case "3":
                case "build a sand castle":
                case "build a castle":
                {
                    if (BoolsList.castleBuilt >= 3)
                    {
                    Console.WriteLine("Marv has built enough sand castles for today.");
                    BoolsList.sandCastle = true;
                    BoolsList.castleBuilt = BoolsList.castleBuilt + 1;
                    Console.ReadLine();
                    Console.Clear();
                    shore();
                    break;
                    } else {
                    Console.WriteLine("Marv begins his architectural journey.");
                    Console.WriteLine("Who knew such a young man had an impressive inate ability for building grainy structures?");
                    Console.WriteLine("");
                    Console.WriteLine("The sand castle considers itself built.");
                    BoolsList.sandCastle = true;
                    BoolsList.castleBuilt = BoolsList.castleBuilt + 1;
                    Console.ReadLine();
                    Console.Clear();
                    shore();
                    break;
                    }
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

            Console.WriteLine("Marvin admires the treasure chest.");
            Console.WriteLine("A seemingly endless supply of CDs pile up from the bottom.");
            Console.WriteLine("Who put these in here?.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Grab a CD");
            Console.WriteLine("2. Dig through the chest");
            Console.WriteLine("3. Use the chest as a boat");
            Console.WriteLine("4. Ignore the chest");
            Console.WriteLine("");
            Console.WriteLine("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "grab a cd":
                case "grab cd":
                case "take cd":
                case "take a cd":
                {
                    Console.WriteLine("Marvin grabs a CD.");
                    Console.WriteLine("Who knows when he might need one of these?");
                    BoolsList.gotCD = true;
                    Console.ReadLine();
                    Console.Clear();
                    chest();
                    break;
                }
                case "2":
                case "dig through the chest":
                case "dig":
                {
                    if ( BoolsList.digCount >= 3)
                    {
                    Console.WriteLine("Marvin finds something peculiar at the the bottom of the CDs.");
                    Console.WriteLine("");
                    Console.WriteLine("It's more CDs.");
                    BoolsList.digCount = BoolsList.digCount - 3;
                    Console.ReadLine();
                    Console.Clear();
                    chest();
                    break;
                    } else {
                    Console.WriteLine("Marvin begins to dig through the chest of CDs.");
                    Console.WriteLine("");
                    Console.WriteLine("There are more CDs.");
                    BoolsList.digCount = BoolsList.digCount + 1;
                    Console.ReadLine();
                    Console.Clear();
                    chest();
                    break;
                    }
                }
                case "3":
                case "use the chest as a boat":
                case "use the chest as boat":
                {
                    if (BoolsList.hasWood == true)
                    {
                    Console.WriteLine("BOAT!");
                    BoolsList.hasBoat = true;
                    Console.ReadLine();
                    Console.Clear();
                    BoatScene.boat();
                    break;
                    } else {
                    Console.WriteLine("How would that work. It's full of CDs?");
                    Console.WriteLine("Its too small and the lid is making it top heavy.");
                    Console.WriteLine("");
                    Console.WriteLine("Maybe if Marv had some wood he could fashion the chest into a little boat.");
                    Console.ReadLine();
                    Console.Clear();
                    chest();
                    break;
                    }
                }
                case "4":
                case "ignore the chest":
                case "ignore":
                {
                    Console.WriteLine("Marvin disregards the chest entirely.");
                    Console.ReadLine();
                    Console.Clear();
                    island();
                    break;
                }
            }
        }

        public static void duke()
        {
            string choice;

            Console.Clear();

            Console.WriteLine("Marvin likes Duke. Duke doesn't exactly like Marvin.");
            Console.WriteLine("Duke is still gripping his dual weapons.");
            Console.WriteLine("Marv is not sure what Duke is doing there, but he's glad that he is.");
            Console.WriteLine("");
            Console.WriteLine("What will Marvin do?");
            Console.WriteLine("");
            Console.WriteLine("1. Slap Duke's Booty");
            Console.WriteLine("2. Grab the gun");
            Console.WriteLine("3. Give Duke Fruit");
            Console.WriteLine("4. Ignore Duke");
            Console.WriteLine("");
            Console.WriteLine("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "slap dukes booty":
                case "slap booty":
                case "slap duke":
                {
                    Console.WriteLine("Marvin slaps Duke's booty as seductively as possible. And boy, was it possible.");
                    Console.WriteLine("Maybe this place should be named love island.");
                    Console.WriteLine("");
                    Console.WriteLine("Duke considers his booty slapped.");
                    Console.ReadLine();
                    Console.Clear();
                    island();
                    break;
                }
                case "2":
                case "grab the gun":
                case "grab gun":
                {
                    if (BoolsList.dukeHasFruit == true)
                    {
                    Console.WriteLine("Distracted by the delectable fruit, Duke completely ignores Marvin bending over to pick up the sidearm.");
                    Console.WriteLine("");
                    Console.WriteLine("Equipped with a weapon, Marvin feels incredibly powerful. Be careful with that gun, Marv.");
                    Console.WriteLine("");
                    Console.WriteLine("The gun considers itself picked up.");
                    BoolsList.hasGun = true;
                    Console.ReadLine();
                    Console.Clear();
                    duke();
                    break;
                    } else if (BoolsList.hasGun == true) {
                    Console.WriteLine("Marvin already has the sidearm.");
                    Console.ReadLine();
                    Console.Clear();
                    duke();
                    break;
                    } else {
                    Console.WriteLine("Woah there partner. Duke raises both guns to show that he isn't messing around.");
                    Console.WriteLine("At least Marv thinks so.");
                    Console.WriteLine("");
                    Console.WriteLine("Maybe if Duke was distracted by something, the sidearm would be easier to acquire.");
                    Console.WriteLine("");
                    Console.WriteLine("Marvin decides to leave the gun alone for now.");
                    Console.ReadLine();
                    Console.Clear();
                    duke();
                    break;
                    }
                }
                case "3":
                case "give duke fruit":
                case "give fruit":
                case "fruit":
                {
                    Console.WriteLine("Marvin shares his bountiful haul of fruit with Duke.");
                    Console.WriteLine("Duke doesn't necessarily need it, but he is grateful nonetheless.");
                    Console.WriteLine("");
                    Console.WriteLine("The fruit considers itself shared.");
                    BoolsList.dukeHasFruit = true;
                    Console.ReadLine();
                    Console.Clear();
                    duke();
                    break;
                }
                case "4":
                case "ignore duke":
                case "ignore":
                {
                    Console.WriteLine("Marvin disregards Duke entirely.");
                    Console.ReadLine();
                    Console.Clear();
                    island();
                    break;
                }
            }
        }
    }
}