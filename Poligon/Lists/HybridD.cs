using System.Collections;
using System.Collections.Specialized;

namespace Poligon.Lists;

public class HybridD
{
    public void MethodName()
    {
        var emailLookup = new HybridDictionary();
        emailLookup["1"] = "Anton";
        emailLookup["2"] = "Dron";
        
        foreach (DictionaryEntry entry in emailLookup)
        {
            Console.WriteLine(entry.Value);
        }
    }

}