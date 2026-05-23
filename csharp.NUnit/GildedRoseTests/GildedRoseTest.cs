using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

using System;

namespace GildedRoseTests;

public class GildedRoseTest
{

    

    [Test]
    public void Foo()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Name, Is.EqualTo("foo"));
    }

    [Test]
    public void Quality_DegradesBy1_WithinSellByDate()
    {
        var items = new List<Item> { new Item { Name = "Common1", SellIn = 1 , Quality = 5 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(4));

    }

    [Test]
    public void Quality_DegradesTwiceAsFast_AfterSellByDate()
    {
        var items = new List<Item> { new Item { Name = "Common1", SellIn = 0 , Quality = 5 } };
        var app = new GildedRose(items);
        items[0].SellIn--;
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(3));
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(1));


    }

    [Test]
    public void Quality_Always_GreaterThanZero()
    {
        var items = new List<Item> { new Item { Name = "Common1", SellIn = 0 , Quality = 1 } };
        var app = new GildedRose(items);
        items[0].SellIn--;
        Assert.That(items[0].SellIn, Is.EqualTo(-1));
        app.UpdateQuality();                                    // intentionally done twice 
        Assert.That(items[0].Quality, Is.EqualTo(0));
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(0));
    }

    [Test]
    public void AgedBrie_QualityIncreasesWithTime()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 1 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(2));

    }

    [Test]
    public void CommonQuality_NeverGreaterThan50()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(50));
    }


    [Test]
    public void QualityOfSulfurasLegendary_Equals80()
    {
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 50 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(80));

    }
    
    [Test]
    public void QualityOfSulfurasLegendary_DoesNotChange()
    {
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(80));

    }

    [Test]
    public void BackstagePasses_IncreaseQualityBy2_Between10and6DaysInclsive()
    {
        var items = new List<Item> { 
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 30 },
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 30 },
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 30 }

        };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(31));
        Assert.That(items[1].Quality, Is.EqualTo(32));
        Assert.That(items[2].Quality, Is.EqualTo(32));

        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(33));
        Assert.That(items[1].Quality, Is.EqualTo(34));
    }

    [Test]
    public void BackstagePasses_IncreaseQualityBy3_Between5and0DaysInclusive()
    {
        var items = new List<Item> {
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 30 },
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 30 }

        };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(33));
        Assert.That(items[1].Quality, Is.EqualTo(33));


    }

    [Test]
    public void BackstagePasses_QualityEquals0_AfterConcert()
    {
        var items = new List<Item> {
         
            new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 30 },


        };

        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(0));

        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(0));

    }
    
        [Test]
    public void ConjuredItems_DegradeQualityTwiceAsFast() 
    {
        var items = new List<Item> {

            new Item {Name = "Conjured Potion Cake", SellIn = 3, Quality = 6},


        };

        var app = new GildedRose(items);
        app.UpdateQuality();

        Assert.That(items[0].Quality, Is.EqualTo(4));


    }
}

