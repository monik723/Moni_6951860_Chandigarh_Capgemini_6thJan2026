using System;
using System.Collections.Generic;

abstract class GroceryReceiptBase2
{
    public Dictionary<string, decimal> Prices { get; set; }
    public Dictionary<string, int> Discounts { get; set; }

    public GroceryReceiptBase2(Dictionary<string, decimal> prices, Dictionary<string, int> discounts)
    {
        Prices = prices;
        Discounts = discounts;
    }

    public abstract IEnumerable<(string fruit, decimal price, decimal total)> 
        Calculate(List<Tuple<string, int>> shoppingList);
}

class GroceryReceipt2 : GroceryReceiptBase2
{
    public GroceryReceipt2(Dictionary<string, decimal> prices, Dictionary<string, int> discounts)
        : base(prices, discounts) { }

    public override IEnumerable<(string fruit, decimal price, decimal total)>
        Calculate(List<Tuple<string, int>> shoppingList)
    {
        foreach (var item in shoppingList)
        {
            var fruit = item.Item1;
            var qty = item.Item2;
            var price = Prices[fruit];

            decimal total = price * qty;

            if (Discounts.ContainsKey(fruit))
                total -= Discounts[fruit];

            yield return (fruit, price, total);
        }
    }
}

class Program
{
    static void Main()
    {
        var prices = new Dictionary<string, decimal>
        {
            {"Apple",2},
            {"Banana",1}
        };

        var discounts = new Dictionary<string, int>
        {
            {"Apple",1}
        };

        var items = new List<Tuple<string, int>>
        {
            Tuple.Create("Apple",3),
            Tuple.Create("Banana",2)
        };

        var g = new GroceryReceipt2(prices, discounts);

        foreach (var x in g.Calculate(items))
            Console.WriteLine($"{x.fruit} {x.price} {x.total}");
    }
}