namespace Poligon.ActionAndFuncDelegations;

public class ActionAndFuncDelegations
{
    public static void Main()
    {
        var action = DoSmth;
        action += () => Console.WriteLine("Action");

        action();

        var func = DoSmthFund;

        func += x =>
        {
            Console.WriteLine(x + 33);
            return 33;
        }; 
        
        func("5");
    }

    private static void DoSmth()
    {
        Console.WriteLine("DoSmth");
    }

    private static int DoSmthFund(string x)
    {
        Console.WriteLine(x + 42);
        return 42;
    }
}