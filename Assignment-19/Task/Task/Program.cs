using System.Collections;
using System.Diagnostics;
using Task;

int[] ints = new int[1000000]; 

Stopwatch stopwath = Stopwatch.StartNew();

stopwath.Start();
var sample = new MyThread();
Thread threadFill = new Thread(() => sample.FillArray(ints));
Thread threadSumm = new Thread(() => sample.Sum(ints));
threadFill.Start();
threadFill.Join();
threadSumm.Start();
stopwath.Stop();

Console.WriteLine("Time elapsed first sample is : {0}", stopwath.Elapsed);


stopwath.Start();
var sample2 = new MyThread1();
Thread thread = new Thread(() => sample2.FillArray(ints));
thread.Start();
stopwath.Stop();

Console.WriteLine("Time elapsed  second sample is : {0}", stopwath.Elapsed);

