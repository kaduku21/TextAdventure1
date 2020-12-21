using System;
using System.Collections.Generic;
using System.Threading;

namespace TextAdventure
{
    class Program
    {
        public static void Game()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("        (                  )              (               (      *         ");
            Console.WriteLine("   (    )\\ )            ( /(   *   )      )\\ )       *   ))\\ ) (  `        ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   )\\  (()/( (   (  (   )\\())` )  /(   ( (()/((    ` )  /(()/( )\\))(  (    ");
            Console.WriteLine("((((_)( /(_)))\\  )\\ )\\ ((_)\\  ( )(_))  )\\ /(_))\\    ( )(_))(_)|(_)()\\ )\\   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" )\\ _ )(_))_((_)((_|(_) _((_)(_(_())_ ((_|_))((_)  (_(_()|_)) (_()((_|(_)  ");
            Console.WriteLine(" (_)_\\(_)   \\ \\ / /| __| \\| ||_   _| | | | _ \\ __| |_   _|_ _||  \\/  | __| ");
            Console.WriteLine("  / _ \\ | |) \\ V / | _|| .` |  | | | |_| |   / _|    | |  | | | |\\/| | _|  ");
            Console.WriteLine(" /_/ \\_\\|___/ \\_/  |___|_|\\_|  |_|  \\___/|_|_\\___|   |_| |___||_|  |_|___| ");
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            string playerClass;
            List<string> classList = new List<string> { "barbarian", "bard", "cleric", "druid" };
            Console.WriteLine("Welcome to CJ and Kaitlin's Adventure game!");
            Console.Write("What is your name?: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome {playerName}!");
            Repick:
            ClassOptions();
            playerClass = Console.ReadLine().ToLower();
            if(classList.Contains(playerClass))
            {
                Console.WriteLine($"You picked {playerClass}!");
                ClassPicker(playerClass);
            }
            else
            {
                while(!classList.Contains(playerClass))
                {
                    Console.WriteLine($"Do not act so foolish {playerName}!\n" +
                    $"You cannot adventure whilst professing to be {playerClass}! Pick one from the list!");
                    goto Repick;
                    //ClassOptions();
                    //playerClass = Console.ReadLine();
                    //ClassPicker(playerClass.ToLower());
                }
            }
            string answer = Console.ReadLine().ToLower();
            if (answer.Equals("yes") || answer.Equals("y"))
            {
                Console.WriteLine("Excellent! Let us proceed with our adventure!");
            }
            else
            {
                Console.Write("Would you like to pick a different class? Y/N: ");
                answer = Console.ReadLine().ToLower();
                if (answer.Equals("yes") || answer.Equals("y"))
                {
                    Console.WriteLine("Excellent!");
                    Console.Clear();
                    Thread.Sleep(50);
                    goto Repick;
                }
                else
                {
                    Console.WriteLine("Goodbye, coward.");
                }

            }
        }
        public static void ClassOptions()
        {
            Console.Write("Please select from these options \n" +
                "Barbarian \n" +
                "Bard \n" +
                "Cleric \n" +
                "Druid\n" +
                "Class: ");
        }
        public static void ClassPicker(string playerClass)
        {
            switch (playerClass.ToLower())
            {
                case "barbarian":
                    string description = "Different as they might be, are defined by their rage: unbridled, unquenchable, and unthinking fury.\n" +
                        "More than a mere emotion, their anger is the ferocity of a cornered predator, the unrelenting assault of a storm,\n" +
                        "the churning turmoil of the sea. For some, their rage springs from a communion with fierce animal spirits.\n" +
                        "Others draw from a roiling reservoir of anger at a world full of pain. For every barbarian, \n" +
                        "rage is a power that fuels not just a battle frenzy but also uncanny reflexes, resilience, and feats of strength.\n";
                    foreach(char c in description)
                    { 
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Console.Write("Do you want to proceed? Y/N: ");
                    break;

                case "bard":
                    description = "Whether scholar, skald, or scoundrel, a bard weaves magic through words and music to inspire allies, \n" +
                        "demoralize foes, manipulate minds, create illusions, and even heal wounds.\n";
                    foreach(char c in description)
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Console.Write("Do you want to proceed? Y/N: ");
                    break;

                case "cleric":
                    description = "Clerics are intermediaries between the mortal world and the distant planes of the gods. As varied as the gods they serve, \n" +
                        "clerics strive to embody the handiwork of their deities. No ordinary priest, a cleric is imbued with divine magic.\n";
                    foreach(char c in description) 
                    {

                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Console.Write("Do you want to proceed? Y/N: ");
                    break;

                case "druid":
                    description = "Whether calling on the elemental forces of nature or emulating the creatures of the animal world, druids are an embodiment of nature’s resilience, \n" +
                        "cunning, and fury. They claim no mastery over nature. Instead, they see themselves as extensions of nature’s indomitable will.\n";
                    foreach  (char c in description)
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Console.Write("Do you want to proceed? Y/N: ");
                    break;
            }

        }
        static void Main(string[] args)
        {
            Game();
        }
    }
}
