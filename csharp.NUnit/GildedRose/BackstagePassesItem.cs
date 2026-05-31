using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class BackstagePassesItem : Item
    {
        public BackstagePassesItem(string name, int quality, int sellin) : base()
        {
            Name = name;
            Quality = quality;
            SellIn = sellin;
        }

        public void Update()
        {
           

            if (SellIn > 10)
            {
                Quality++;
            }
            else if (SellIn <= 10 && SellIn >= 6)
            {
                Quality += 2;
            }
            else if (SellIn <= 5 && SellIn > 0)
            {
                Quality += 3;
            } else if (SellIn <= 0 ){
                Quality = 0;
            }

            if (Quality < 0) Quality = 0;
            if (Quality > 50) Quality = 50;


            SellIn--;
        }
    }
}
