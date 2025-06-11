class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Item Manager!");
        ItemManager manager = new ItemManager();

        // Part One: Fix the NullReferenceException
        manager.AddItem("Apple");
        manager.AddItem("Banana");

        manager.PrintAllItems();

        // Part Two: Implement the RemoveItem method
        manager.RemoveItem("Apple");
        manager.PrintAllItems();

        // Part Three: Introduce a Fruit class and use the ItemManager<Fruit> to add a few fruits and print them on the console.
        ItemManager<Fruit> fruitManager = new ItemManager<Fruit>();
        fruitManager.AddItem(new Fruit("Apple", "Red"));
        fruitManager.AddItem(new Fruit("Banana", "Yellow"));
        fruitManager.AddItem(new Fruit("Grapes", "Green"));

        Console.WriteLine("\nFruit List:");
        fruitManager.PrintAllItems();
    }
}

public class ItemManager : IItemManager<string>
{
    private List<string> items;
    public ItemManager()
    {
        items = new List<string>();
    }

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void RemoveItem(string item)
    {
        if(items.Contains(item))
        {
            items.Remove(item);
            Console.WriteLine($"Removed : {item}");
        }
        else
        {
            Console.WriteLine($"Item not found : {item}");
        }
    }

    public void ClearAllItems()
    {
        items = [];
    }
}

public class ItemManager<T> : IItemManager<T>
{
    private List<T> items;

    public ItemManager()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void RemoveItem(T item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Console.WriteLine($"Removed : {item}");
        }
        else
        {
            Console.WriteLine($"Item not found : {item}");
        }
    }

    public void ClearAllItems()
    {
        items = [];
    }
}