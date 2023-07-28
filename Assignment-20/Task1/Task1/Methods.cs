using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Methods
    {
        public int[] FillArray(int[] intArray)
        {
            for (int i = 0; i < 1000000; i++)
            {
                intArray[i] = i + 10;
                Console.WriteLine($"{i} value is {intArray[i]}");
            }
            return intArray;
        }
        public void Sum(int[] intArray)
        {
            var result = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                result += intArray[i];
            }
            Console.WriteLine("result is: " + Convert.ToString(result));
        }
    }
}
