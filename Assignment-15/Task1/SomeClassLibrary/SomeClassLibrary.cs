using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeClassLibrary
{
    public class Calculator
    {
        public Calculator() 
        {
        }
        private double _number;
        public double Number { get; set; }
        public void Clear() 
        {
        }
        private void DoClear() 
        { 
        }

        public double Add(double number) 
        { 
            return number;
        }
        public static double Pi()
        {
            return 10;
        }
        public static double GetPi() 
        {
            return Pi();
        }
    }
}
