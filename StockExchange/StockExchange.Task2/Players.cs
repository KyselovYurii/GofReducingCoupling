﻿namespace StockExchange.Task2
{
    public class Players
    {
        public RedSocks RedSocks { get; set; }
        public Blossomers Blossomers { get; set; }

        public Players(RedSocks redSocks, Blossomers blossomers)
        {
            RedSocks = redSocks;
            Blossomers = blossomers;
        }
    }
}
