﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarFootball.Models
{
    public class PlayerCard : Card
    {
        public PlayerCard()
        {
            CardType = CardType.Player;
        }

        public string Club { get; set; }
        public string Nation { get; set; }
        public string League { get; set; }
        public PlayerPosition Position { get; set; }
        public List<PlayerAttributeValue> PlayerAttributes { get; set; }
    }
}
