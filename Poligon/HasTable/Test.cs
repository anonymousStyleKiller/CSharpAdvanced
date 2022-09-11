namespace Poligon.HasTable;

public class Test
{
    public Test(string name)
    {
        Name = name;
    }

    private string Name { get; set; }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Test otherClass)
        {
            return false;
        }

        return otherClass.Name == Name;
    }
}