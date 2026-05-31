using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class NormalItem : Item
    {
        public NormalItem(string name,int quality, int sellin) : base()
        {
            Name = name;
            Quality = quality;
            if (Quality > 50) Quality = 50;
            SellIn = sellin;
        }

        public void Update()
        {


            if (Quality > 50) Quality = 50;

            Quality--;

            if (SellIn <= 0) Quality--;

            if (Quality < 0) Quality = 0;

            SellIn--;


        }


    }
}
