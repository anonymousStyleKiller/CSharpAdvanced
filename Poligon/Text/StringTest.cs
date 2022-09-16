using System.Globalization;

namespace Poligon.Text;

public class StringTest 
{
    public static void Start()
    {
        var culture = CultureInfo.CurrentCulture;
        var intern = String.Intern(Console.ReadLine());
        Console.WriteLine(culture);
        var dict = new Dictionary<string, string>();
        dict.ToList();
    }
    
}