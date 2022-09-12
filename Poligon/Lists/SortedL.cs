using System.Collections;

namespace Poligon.Lists;

public class SortedL
{
    public void MethodName()
    {
        var x = new SortedList(new DescendingComparer());
        x["1"] = 1;
        x["2"] = 2;
        x["5"] = 5;
        x["3"] = 3;
      
        foreach (DictionaryEntry entry in x)
        {
            Console.WriteLine(entry.Value);
        }
    }
}

internal class DescendingComparer : IComparer
{
    private CaseInsensitiveComparer _comparer = new();
    public int Compare(object? x, object? y)
    {
        var res = _comparer.Compare(x, y);
        return res;
    }
}