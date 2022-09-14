namespace Poligon.Text;

public static class StringTest
{
    public static void Start()
    {
        var s = new string("Hi");
        var intern = String.Intern(Console.ReadLine());
        Console.WriteLine(intern == s);
    }
}