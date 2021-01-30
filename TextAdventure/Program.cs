using System;
using System.Collections.Generic;
using System.Threading;

namespace TextAdventure
{
    class Program:ClassMethods
    {
        public static void Game()
        {
            Player player = new Player();
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

            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("Welcome to CJ and Kaitlin's Adventure game!");
            Console.Write("What is your name?: ");
            player.playerName = Console.ReadLine();
            Console.WriteLine($"Welcome {player.playerName}!");
            Repick:
            ClassOptions();
           player.playerClass = Console.ReadLine().ToLower();
            if(ClassMethods.classList.Contains(player.playerClass))
            {
                Console.WriteLine($"You picked {player.playerClass}!");
                ClassPicker(classMethods.playerClass);
            }
            else
            {
                while(!classList.Contains(player.playerClass))
                {
                    Console.WriteLine($"Do not act so foolish {player.playerName}!\n" +
                    $"You cannot adventure whilst professing to be {classMethods.playerClass}! Pick one from the list!");
                    goto Repick;
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
        
        static void Main(string[] args)
        {
            Game();
        }
    }
}
