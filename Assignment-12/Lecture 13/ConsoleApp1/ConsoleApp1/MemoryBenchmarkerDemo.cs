using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Task_1
{
    [MemoryDiagnoser]
    public class MemoryBenchmarkerDemo
    {
        int NumberOfItems = 100000;
        [Benchmark]
        public string ConcatStringsUsingStringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < NumberOfItems; i++)
            {
                sb.Append("Hello World!" + i);
            }
            return sb.ToString();
        }
        [Benchmark]
        public string ConcatStringsUsingGenericList()
        {
            var list = new List<string>(NumberOfItems);
            for (int i = 0; i < NumberOfItems; i++)
            {
                list.Add("Hello World!" + i);
            }
            return list.ToString();
        }

        [Benchmark]
        public string MyDictionary()
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            foreach (KeyValuePair<int, string> kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                return kvp.Value;
            }

            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
                };
            return "";

            foreach (var kvp in cities)
            {
                return kvp.Key;
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

        }

        [Benchmark]
        public string MySortedList()
        {
            SortedList mySL = new SortedList();
            mySL.Add("Third", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");

            Console.WriteLine("mySL");
            Console.WriteLine("  Count:    {0}", mySL.Count);
            Console.WriteLine("  Capacity: {0}", mySL.Capacity);
            Console.WriteLine("  Keys and Values:");

            Console.WriteLine("\t-KEY-\t-VALUE-");
            for (int i = 0; i < mySL.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", mySL.GetKey(i), mySL.GetByIndex(i));
                return "";
            }
            Console.WriteLine();
            return "";
        }

        [Benchmark]
        public string MyHashSet()
        {
            HashSet<string> myhash1 = new HashSet<string>();

            myhash1.Add("Tbilisi");
            myhash1.Add("Batumi");
            myhash1.Add("Kutaisi");
            myhash1.Add("Telavi");
            myhash1.Add("Mestia");
            Console.WriteLine("Elements of myhash1:");
            return "";

            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
                return "";

            }
        }

        [Benchmark]
        public string MyStack()
        {
            Stack my_stack = new Stack();

            my_stack.Push("Tbilisi");
            my_stack.Push("Sakartveli");
            my_stack.Push('G');
            my_stack.Push(null);
            my_stack.Push(2023);
            my_stack.Push(490.98);

            foreach (var elem in my_stack)
            {
                Console.WriteLine(elem);
                return "";
            }
            return "";
        }

        [Benchmark]
        public string MyArray()
        {
            string[] strings = { "Tbilisi" , "Batumi", "Kutaisi" , "London", "Berlin", "Zagrebi" };
            for (int i = 0; i < strings.Length; i++)
            {
                return strings[i];
            }
            return "";
        }


    }
}
