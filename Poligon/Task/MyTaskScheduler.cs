namespace Poligon.Task;

public static class MyTaskScheduler
{
    
    public static void MyTask()
    {
        var threadId = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine($"Main id : {threadId}");
    }
    
    
    public static void M()
    {
        var scheduler = new DelayMyTaskScheduler();
        var factor = new TaskFactory(scheduler);
        var task = factor.StartNew(MyTask);
        var awaiter = task.GetAwaiter();
        while (!awaiter.IsCompleted)
        {
            Console.WriteLine(".");
        }

        Console.WriteLine("Done");
    }
}

public class DelayMyTaskScheduler : TaskScheduler
{
    private readonly Queue<System.Threading.Tasks.Task> _queue = new();
    private readonly AutoResetEvent _event = new(false);

    protected override IEnumerable<System.Threading.Tasks.Task>? GetScheduledTasks()
    {
        return _queue;
    }

    protected override void QueueTask(System.Threading.Tasks.Task task)
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        _queue.Enqueue(task);
        void Callback(object state, bool timedOut) => TryExecuteTask(_queue.Dequeue());

        ThreadPool.RegisterWaitForSingleObject(_event, Callback, null, 2000, true);
    }

    protected override bool TryExecuteTaskInline(System.Threading.Tasks.Task task, bool taskWasPreviouslyQueued)
    {
        return false;
    }
}