using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class ConjuredItem : Item
    {
        public ConjuredItem(string name, int quality, int sellin) : base()
        {
            Name = name;
            Quality = quality;
        
            SellIn = sellin;
        }

        public void Update()
        {


            if (Quality > 50) Quality = 50;

            Quality-=2;

            if (SellIn < 0) Quality-=2;

            if (Quality < 0) Quality = 0;

            SellIn--;

        }
    }
}
