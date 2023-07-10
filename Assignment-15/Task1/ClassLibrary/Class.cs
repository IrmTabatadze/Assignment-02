using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Class
    {
        public Class() 
        {
        }

        private double _number1;
        private double _number2;
        public double Number { get; set; }

        public double Plus(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Subtract(double number1, double number2)
        {
            if (number1 < number2)
            {
                Console.WriteLine("\nThe result will be negative");
                return number1 - number2;
            }
            return number1 - number2; 
        }

    }
}
