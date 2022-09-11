using System.Collections;

namespace Poligon.HasTable;

public class OverrideHashTableGetHashCode
{
    public void MethodName()
    {
        var hastTable = new Hashtable();
        var key1 = new Test("Anton");
        var key2 = new Test("Anton");
        hastTable[key1] = 1;
        hastTable[key2] = 2;
        Console.WriteLine(hastTable.Count);
    }
    
}