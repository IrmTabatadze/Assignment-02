using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SearchFile
    {
        public static string SearchUser(string Name)
        {
            var Path = @"C:\Users\IrmTabatadze\Desktop\Irma\Assignment-02\list.txt";
            var Sourse = File.ReadLines(Path);

            foreach (var item in Sourse)
            {
                if (item.Contains(Name))
                {
                    Console.WriteLine("Result is: " + item);
                    return item;
                    break;
                }
            }
            Console.WriteLine("Result is empty!");
            return "";

        }

        public static string SearchUser(int Age)
        {
            var Path = @"C:\Users\IrmTabatadze\Desktop\Irma\Assignment-02\list.txt";
            var Sourse = File.ReadLines(Path);

            foreach (var item in Sourse)
            {
                if (item.Contains(Convert.ToString(Age)))
                {
                    Console.WriteLine("Result is: " + item);
                    return item;
                }
            }
            Console.WriteLine("Result is empty!");
            return "";
        }

        public static string SearchUser(string Name, string FullName)
        {
            var Path = @"C:\Users\IrmTabatadze\Desktop\Irma\Assignment-02\list.txt";
            var Sourse = File.ReadLines(Path);

            foreach (var item in Sourse)
            {
                if (item.Contains(Name + " " + FullName))
                {
                    Console.WriteLine("Result is: " + item);
                    return item;
                    break;
                }
            }
            Console.WriteLine("Result is empty!");
            return "";

        }
    }
}
