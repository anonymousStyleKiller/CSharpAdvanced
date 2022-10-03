namespace Poligon.Events;

public static class SimpleEvents
{
    public static void Main()
    {
        var cat = new Cat()
        {
            Id = 1,
            Name = "Cat",
            Health = 100
        };
        cat.OnHealthChanged += CatOnOnHealthChanged;
        cat.Health = 200;
        cat.Health = 155;
        cat.Name = "New";

    }

    private static void CatOnOnHealthChanged(object? sender, int e)
    {
        var cat = (Cat)sender;
        Console.WriteLine($"{cat.Name} has health: {cat.Health}");
    }
}