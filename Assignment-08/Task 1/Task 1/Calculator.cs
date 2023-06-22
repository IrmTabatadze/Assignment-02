using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class Calculator
    {
        public static int AddNumbers(int FirstValue, int SecondValue)
        {
            return FirstValue + SecondValue;

        }
        public static int Subtract(int FirstValue, int SecondValue)
        { 
            return FirstValue - SecondValue; 
        }
        public static int Multiply(int FirstValue, int SecondValue)
        {
            return FirstValue * SecondValue; 
        }
        public static int Divide(int FirstValue, int SecondValue)
        {
            return FirstValue / SecondValue;
        }
        public static int Pow(int Value, int UserPow)
        {
            int CountPow = 1;
            for (int i = 0; i < UserPow; i++)
            {
                CountPow = CountPow * Value;
            }

            return CountPow; 
        }

        public static int Sqrt(int UserNumber)
        {
            int Sqrt = UserNumber / 2;
            int temp = 0;

            while (Sqrt != temp)
            {
                temp = Sqrt;

                Sqrt = (UserNumber / temp + temp) / 2;
            }

            return Sqrt;
        
        }

    }
}
