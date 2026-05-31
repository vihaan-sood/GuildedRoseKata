using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;
 

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;


        int quality;
        int sellIn;
        string name;

        for (int i = 0; i < Items.Count; i++)
        {
            quality = (int)Items[i].Quality;
            sellIn = (int)Items[i].SellIn;
            name = (string)Items[i].Name;

            if (name.Contains("Sulfuras"))
            {
                Items[i] = new LegendaryItem(name, quality, sellIn);
            }
            else if (name.Contains("Aged Brie"))
            {
                Items[i] = new AgedBrieItem(name, quality, sellIn);
            }
            else if (name.Contains("Backstage passes"))
            {
                Items[i] = new BackstagePassesItem(name, quality, sellIn);
            }
            else if (name.Contains("Conjured"))
            {
                Items[i] = new ConjuredItem(name, quality, sellIn);
            }
            else
            {
                Items[i] = new NormalItem(name, quality, sellIn);
            }


        }


    }

    public void UpdateQuality()
    {
        

        foreach (var item in Items) {

           switch (item)
            {

                case LegendaryItem:
                    break;
                case AgedBrieItem:
                    ((AgedBrieItem)item).Update();
                    break;
                case BackstagePassesItem:
                    ((BackstagePassesItem)item).Update();
                    break;
                case ConjuredItem:
                    ((ConjuredItem)item).Update();
                    break;
                case NormalItem:
                    ((NormalItem)item).Update();
                    break;


            }
        }

    }
}