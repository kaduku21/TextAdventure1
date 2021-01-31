using System;
using System.Collections.Generic;
using System.Threading;
using static TextAdventure.Spells;
using static TextAdventure.PlayerClasses;
using static TextAdventure.ClassMethods;
namespace TextAdventure
{
    class Program : ClassMethods
    {
        public static void Game()
        {
            Console.WriteLine();
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
            Player player = new Player();
            Console.WriteLine("Welcome to CJ's Adventure game!");
            Console.Write("What is your name?: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome {playerName}!");
        Repick:
            ClassOptions();
            string selected = Console.ReadLine().ToLower();
            if (classList.Contains(selected))
            {
                //Console.WriteLine($"You picked {player.playerClass.ClassName}!");
                ClassPicker(selected, playerName);
            }
            else
            {
                while (!classList.Contains(selected))
                {
                    Console.WriteLine($"Do not act so foolish {player.playerName}!\n" +
                    $"You cannot adventure whilst professing to be {selected}! Pick one from the list!");
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
