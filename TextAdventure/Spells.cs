using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    class Spells
    {
        public Spells(string _spellname, string _description, string _action)
        {
            SpellName = _spellname;
            Description = _description;
            Action = _action;
        }
        public string SpellName { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
    }
}
