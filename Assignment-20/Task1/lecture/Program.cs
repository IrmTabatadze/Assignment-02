//var localTask = Task.Run(ExampleMethodWithHeavyWork);
//MethodExamples();
//FactoryStartWithResult();
using lecture;

CancellationExample();
Console.WriteLine("outside control returned to thread {0}", Thread.CurrentThread.ManagedThreadId);

Console.ReadKey();

static void NewTask()
{
    Console.WriteLine("main method runs in thread: {0}", Thread.CurrentThread.ManagedThreadId);
    var task = new Task(ExampleMethod);

    var task2 = new Task(() => { Console.WriteLine("Something"); });

    task.Start();
    task.Wait();
    task2.Start();
    Console.WriteLine("control returned to thread {0}", Thread.CurrentThread.ManagedThreadId);

    var heavyTask = new Task(ExampleMethodWithHeavyWork);
    heavyTask.Start();

    Console.WriteLine("ragaca");

    heavyTask.Wait();
}

static void FactoryStart()
{
    Console.WriteLine($"main method running on ${Thread.CurrentThread.ManagedThreadId}");
    var cs = new CancellationTokenSource();
    var task = Task.Factory.StartNew(ExampleMethodWithHeavyWork, cs.Token, TaskCreationOptions.LongRunning,
        TaskScheduler.Default);

    task.Wait();

    Console.WriteLine($"execution returned on thread #{Thread.CurrentThread.ManagedThreadId}");
}

static void FactoryStartWithResult()
{
    Console.WriteLine($"main method running on ${Thread.CurrentThread.ManagedThreadId}");
    Task<string> call = Task.Factory.StartNew(() => GetApiResult("https://jsonplaceholder.typicode.com/posts"));

    try
    {
        Console.WriteLine(call.Result);
    }
    catch (AggregateException ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.WriteLine($"execution returned on thread #{Thread.CurrentThread.ManagedThreadId}");
}

static string GetApiResult(string uri)
{
    using var httpClient = new HttpClient();
    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    return httpClient.GetStringAsync(uri).Result;
}

static async Task MethodExamples()
{

    var task1 = Task.Run(() =>
    {
        Thread.Sleep(15);
        Console.WriteLine("1");
    });
    var task12 = Task.Run(() =>
    {
        Thread.Sleep(20);
        Console.WriteLine("2");
    });
    var task3 = Task.Run(() =>
    {
        Thread.Sleep(30);
        Console.WriteLine("3");
    });
    var task4 = Task.Run(() =>
    {
        Thread.Sleep(40);
        Console.WriteLine("4");
    });

    //Task.WaitAll(new Task[] {task1, task12, task3 ,task4});
    Task.WaitAny(new Task[] { task1, task12, task3, task4 });

    var task = Task.WhenAll(new Task[] { task1, task12, task3, task4 });
    await task;
    Console.WriteLine("Other operation");
}

static void CancellationExample()
{
    var cancellationSource = new CancellationTokenSource();
    var task = new CancellableTask().CreateCancellabelTask(cancellationSource.Token);

    Console.WriteLine("press c to stop");

    var input = Console.ReadKey().KeyChar;

    if (input == 'c')
    {
        cancellationSource.Cancel();
    }

    try
    {
        //task.Wait();

        if (task.Status == TaskStatus.Faulted)
        {
            Console.WriteLine(task.Exception.Message);
            throw new Exception("error");
        }
    }
    catch (AggregateException exception)
    {
        if (exception.InnerExceptions.Any(x => x is TaskCanceledException))
            Console.WriteLine("Cancellation was requested");
    }
}
static void ExampleMethod()
{
    Console.WriteLine("ExampleMethod method runs in thread: {0}", Thread.CurrentThread.ManagedThreadId);
    var insideTask = new Task(ExampleMethodWithHeavyWork);
    insideTask.Start();
    insideTask.Wait();
    Console.WriteLine("ExampleMethod method runs in thread: {0}", Thread.CurrentThread.ManagedThreadId);

    Console.WriteLine("Doing some work from thread: {0}", Thread.CurrentThread.ManagedThreadId);
}

static void ExampleMethodWithHeavyWork()
{
    Thread.Sleep(2000);
    Console.WriteLine($"Doing heavy work from thread {Thread.CurrentThread.ManagedThreadId}");
}