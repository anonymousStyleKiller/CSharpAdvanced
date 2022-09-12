using System.Collections;

namespace Poligon;

public class InsensitiveComparer : IEqualityComparer
{
    private readonly CaseInsensitiveComparer _comparer = new();
    
    public bool Equals(object? x, object? y)
    {
        return _comparer.Compare(x, y) == 0;
    }

    public int GetHashCode(object obj)
    {
        return obj.ToString().ToLowerInvariant().GetHashCode();
    }
}