using System.Collections;

namespace Poligon.Lists;

public class SortedL
{
    public void MethodName()
    {
        var x = new SortedSet<int>();
        x.Add(1);
        x.Add(7);
        x.Add(4);

        foreach (var entry in x)
        {
            Console.WriteLine(entry);
        }
    }
}