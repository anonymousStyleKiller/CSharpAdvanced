namespace Poligon.Task;

public static class TaskEx
{
    public static void Main()
    {
        var threadId = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine($"Main id : {threadId}");
        var action = new Action(MyTaskMethod);
        var task = new System.Threading.Tasks.Task(action);
        task.Start();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(". ");
        }
        Console.WriteLine($"End Main {threadId}");
        Console.ReadLine();
    }

    private static void MyTaskMethod()
    {
        var threadId = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine($"MyTaskMethod id : {threadId}");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("+ ");
        }

        Console.WriteLine($"End MyTaskMethod {threadId}");
    }
}