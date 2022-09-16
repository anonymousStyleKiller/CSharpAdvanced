namespace Poligon.Reflection;

public static class Reflection
{
    public static void Main()
    {
        var myClass = new MyClass();
        Type type;
        type = myClass.GetType();
        Console.WriteLine(type.Namespace);
    }
}

public class MyClass
{
    
}