namespace Poligon.Attributes;

[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
public class AttributeWorkAttribute : Attribute
{
    public string Name { get; set; }

    public string _node;
    public AttributeWorkAttribute(string node)
    {
        _node = node;
    }

    public void Mehod()
    {
        Console.WriteLine(_node +" " + Name);
    }
}