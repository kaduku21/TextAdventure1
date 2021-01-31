using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static TextAdventure.PlayerClasses;
//using static TextAdventure.Spells;
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
        public static void ClassPicker(string playerClass, string playerName)
        {
            switch (playerClass.ToLower())
            {
                //case "barbarian":
                //    string description = "Different as they might be, are defined by their rage: unbridled, unquenchable, and unthinking fury.\n" +
                //        "More than a mere emotion, their anger is the ferocity of a cornered predator, the unrelenting assault of a storm,\n" +
                //        "the churning turmoil of the sea. For some, their rage springs from a communion with fierce animal spirits.\n" +
                //        "Others draw from a roiling reservoir of anger at a world full of pain. For every barbarian, \n" +
                //        "rage is a power that fuels not just a battle frenzy but also uncanny reflexes, resilience, and feats of strength.\n";
                //    TextTyper(description, 10);
                //    Console.Write("Do you want to proceed? Y/N: ");
                //    break;

                case "bard":
                   string description = "Whether scholar, skald, or scoundrel, a bard weaves magic through words and music to inspire allies, \n" +
                        "demoralize foes, manipulate minds, create illusions, and even heal wounds.\n";
                    TextTyper(description, 10);
                    
                    Spells healingWord = new Spells
                    {
                        SpellName = "Healing Word",
                        Action = "You say a word and you restore health.",
                        Description = "A creature of your choice that you can see within range regains hit points equal to 1d4 + your spellcasting ability modifier. \n" +
                        "This spell has no effect on undead or constructs."
                    };
                    Spells psychicScream = new Spells
                    {
                        SpellName = "Psychic Scream",
                        Action = "You hold the sides of you head and drive a psychic attack into the mind of your attacker",
                        Description = "You unleash the power of your mind to blast the intellect of up to ten creatures of your choice that you can see within range."
                    };
                    Spells dissonantWhispers = new Spells
                    {
                        SpellName = "Dissonant Whisper",
                        Action = "You whisper something very rude, and it hurts your target very deeply.",
                        Description = "You whisper a discordant melody that only one creature of your choice within range can hear, \n" +
                        "wracking it with terrible pain. The target must make a Wisdom saving throw."
                    };
                    PickedClass bard = new PickedClass
                    {
                        ClassName = "Bard",
                        Health = 20,
                        Spells = new List<Spells> { psychicScream, healingWord, dissonantWhispers}
                    };
                    Player player = new Player();
                    player.playerClass = bard;
                    player.playerName = playerName;

                    string SpellsText = "The bard has the following abilities: ";
                    TextTyper(SpellsText, 10);
                    foreach(Spells spells in bard.Spells)
                    {
                        Console.WriteLine();
                        TextTyper(spells.SpellName, 10);
                        Console.WriteLine();
                        TextTyper(spells.Description, 10);
                    }
                    Console.WriteLine();
                    Console.Write("Do you want to proceed? Y/N: ");
                    break;

                //case "cleric":
                //    description = "Clerics are intermediaries between the mortal world and the distant planes of the gods. As varied as the gods they serve, \n" +
                //        "clerics strive to embody the handiwork of their deities. No ordinary priest, a cleric is imbued with divine magic.\n";
                //    TextTyper(description, 10);
                //    Console.Write("Do you want to proceed? Y/N: ");
                //    break;

                //case "druid":
                //    description = "Whether calling on the elemental forces of nature or emulating the creatures of the animal world, druids are an embodiment of nature’s resilience, \n" +
                //        "cunning, and fury. They claim no mastery over nature. Instead, they see themselves as extensions of nature’s indomitable will.\n";
                //    TextTyper(description, 10);
                //    Console.Write("Do you want to proceed? Y/N: ");
                //    break;
            }
        }
       
    }

    public class Enemy
    {
        public string EnemyName { get; set; }
        public int EnemyHealth { get; set; }
    }
}
