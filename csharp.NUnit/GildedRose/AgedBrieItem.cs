using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class AgedBrieItem : Item
    {
        public AgedBrieItem(string name, int quality, int sellin) : base()
        {
            Name = name;
            Quality = quality;
            SellIn = sellin;
        }

        public void Update()
        {
       

            
             Quality++;

            if (SellIn <= 0) Quality++;

            if (Quality < 0) Quality = 0;
            if (Quality > 50) Quality = 50;


            SellIn--;
        }
    }
}
