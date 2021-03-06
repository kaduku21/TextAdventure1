﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    class PlayerClasses : Spells
    {
        public class Player
        {
            public string playerName { get; set; }
            public PickedClass playerClass { get; set; }
        }
        public class PickedClass
        {
            public string ClassName { get; set; }
            public int Health { get; set; }
            public List<Spells> Spells { get; set; }
        }

    }
}

