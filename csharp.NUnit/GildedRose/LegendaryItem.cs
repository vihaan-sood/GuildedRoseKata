using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class LegendaryItem : Item
    {
    
        public LegendaryItem(string name, int quality, int sellin) : base()
        {
            Name = name;
            Quality = quality;
            if (Quality != 80) Quality = 80;
            SellIn = sellin;
        }


    }
}
