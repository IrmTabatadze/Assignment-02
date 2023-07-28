using System.Collections;
using System;
using Task1;
using System.Linq;
using System.Diagnostics;

int[] ints = new int[1000000];

Stopwatch stopwatch = Stopwatch.StartNew();
var task = new Methods().FillArray(ints);
new Methods().Sum(ints);
stopwatch.Stop();

Console.WriteLine("Time elapsed task sample is : {0}", stopwatch.Elapsed);
