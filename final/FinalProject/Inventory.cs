using System;
using System.Collections.Generic;

public class Inventory
{
    private List<Item> _items;

    public Inventory()
    {
        _items = new List<Item>(); // Initialize the list in the constructor
    }

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        _items.Remove(item);
    }

    public double GetTotalWeight()
    {
        double totalWeight = 0;
        foreach (var item in _items)
        {
            totalWeight += item.Weight;
        }
        return totalWeight;
    }

    public class Item
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Item(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
