using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextAdventure
{
    class ClassMethods
    {
        //public Player player = new Player();
        public static ClassMethods classMethods = new ClassMethods();
        public string playerClass { get; set; }
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
        public void ClassesandSpells()
        {
            PickedClass bard = new PickedClass();
            bard.ClassName = "Bard";
            bard.Health = 20;
            Spell dissonantWhispers = new Spell();
            dissonantWhispers.SpellName = "Dissonant Whispers";
            dissonantWhispers.Description = "You whisper a discordant melody that only one creature of your choice within range can hear, \n" +
                "wracking it with terrible pain.The target must make a Wisdom saving throw.On a failed save, \n" +
                "it takes 3d6 psychic damage and must immediately use its reaction, \n" +
                "if available, to move as far as its speed allows away from you. \n" +
                "The creature doesn’t move into obviously dangerous ground, such as a fire or a pit. \n" +
                "On a successful save, the target takes half as much damage and doesn’t have to move away. \n" +
                "A deafened creature automatically succeeds on the save.";
            string whisper = Console.ReadLine();
            dissonantWhispers.Action = $"";

            bard.Spells = new List<Spell>() { dissonantWhispers};

            PickedClass barbarian = new PickedClass();
            barbarian.ClassName = "Barbarian";
            barbarian.Health = 40;
        }
    }

    public class Player
    {
        public string playerName { get; set; }
        public string playerClass { get; set; }
        public string playerHealth { get; set; }
        public List<string> spells { get; set; }
    }
    public class PickedClass
    {
        public string ClassName { get; set; }
        public int Health { get; set; }
        public List<Spell> Spells { get; set; }
    }
    public class Spell
    {
        public string SpellName { get; set; }
        public string Description { get; set; } 
        public string Action { get; set; }
    }
    public class Enemy
    {
        public string EnemyName { get; set; }
        public int EnemyHealth { get; set; }
    }
}
