using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static TextAdventure.PlayerClasses;
using static TextAdventure.Spells;
namespace TextAdventure
{
    class ClassMethods
    {
        //public string playerClass { get; set; }
        public static List<string> classList = new List<string> { "barbarian", "bard", "cleric", "druid" };
        public static void ClassOptions()
        {
            Console.Write("Please select from these options \n" +
                "Barbarian \n" +
                "Bard \n" +
                "Cleric \n" +
                "Druid\n" +
                "Class: ");
        }
        public static void TextTyper(string text, int speed)
        {
            foreach(char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
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
                    TextTyper(description, 10);
                    Console.Write("Do you want to proceed? Y/N: ");
                    break;

                case "bard":
                    description = "Whether scholar, skald, or scoundrel, a bard weaves magic through words and music to inspire allies, \n" +
                        "demoralize foes, manipulate minds, create illusions, and even heal wounds.\n";
                    TextTyper(description, 10);
                    Console.Write("Do you want to proceed? Y/N: ");
                    break;

                case "cleric":
                    description = "Clerics are intermediaries between the mortal world and the distant planes of the gods. As varied as the gods they serve, \n" +
                        "clerics strive to embody the handiwork of their deities. No ordinary priest, a cleric is imbued with divine magic.\n";
                    TextTyper(description, 10);
                    Console.Write("Do you want to proceed? Y/N: ");
                    break;

                case "druid":
                    description = "Whether calling on the elemental forces of nature or emulating the creatures of the animal world, druids are an embodiment of nature’s resilience, \n" +
                        "cunning, and fury. They claim no mastery over nature. Instead, they see themselves as extensions of nature’s indomitable will.\n";
                    TextTyper(description, 10);
                    Console.Write("Do you want to proceed? Y/N: ");
                    break;
            }
        }
       
    }

    public class Enemy
    {
        public string EnemyName { get; set; }
        public int EnemyHealth { get; set; }
    }
}
