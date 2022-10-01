namespace Poligon.Delegate;

public static class BaseDelegate
{
    public static void Main()
    {
        var del = new CalcSum(AddSum);
         del += MultipleSum;
         del(5, 3);
         del -= MultipleSum;
         del -= AddSum;
         del += (x, y) => Console.WriteLine(x/y);
         del(100, 10);
    }
    
    public static void PrintName(string print)
    {
        Console.WriteLine(print);
    }

    public static void MethodWithString(MyVoidDelegateWithString x)
    {
        x("Anton");
        Console.WriteLine("Kharchenko");
    }

    public static void AddSum(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    
    public static void MultipleSum(int x, int y)
    {
        Console.WriteLine(x * y);
    }
  
}

public delegate void MyVoidDelegateWithString(string number);

public delegate void MyVoidDelegate(int x);

public delegate void CalcSum(int first, int second);