using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Calculator
    {
        public static double Plus(double Number1, double Number2)
        {
            double Result = Number1 + Number2;
            Console.WriteLine("Plus result is : " + Result);
            return Result;
        }

        public static double MathOperation(double Num1, double Num2)
        {
            if ((Num1 == 0) || (Num2 == 0))
            {
                return 0;
            }
            else
            {
                var Result = Num1 * Num2;
                Console.WriteLine("Multiply result is : " + Result);
                return Result;

            }
                
        }

        public static double MathOperation(double Num1)
        {
            if (Num1 == 0)
            {
                return 0;
            }
            else
            {
                var Result = Math.Sqrt(Num1);
                Console.WriteLine("Sqrt result is : " + Result);
                return Result;

            }

        }

    }
}
