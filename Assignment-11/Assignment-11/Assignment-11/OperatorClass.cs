using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    public class OperatorClass<T> : IMath<T> where T : class
    {
        //private T _value1;
        //private T _value2;
        //T Value1;
        //T Value2;

        public OperatorClass() 
        { 
        }
        public double AddValues(T Value1, T Value2)
        {
            //var val = new BaseClass.OperatorClass<>
            double SummValue;
            SummValue = Convert.ToDouble(Value1) + Convert.ToDouble(Value2);
            return SummValue;
               
        }
        public double SubstractValues(T Value1, T Value2)
        {
            double SummValue = 0;

            if (Convert.ToDouble(Value1) > Convert.ToDouble(Value2))
            {
                SummValue = Convert.ToDouble(Value1) - Convert.ToDouble(Value2);
            }
            else if (Convert.ToDouble(Value2) > Convert.ToDouble(Value1))
            {
                SummValue = Convert.ToDouble(Value2) - Convert.ToDouble(Value1);
            }
            else
            {
                return SummValue;
            }
            
            return SummValue;

        }
        //public double MulMultiplyValues(T Value1, T Value2)
        //{
        //    double SummValue = 0;

        //    SummValue = Convert.ToDouble(Value1) * Convert.ToDouble(Value2);
        
        //    return SummValue;
        //}

        public double MultiplyValues(T Value1, T Value2)
        {
            double SummValue = 0;

            SummValue = Convert.ToDouble(Value1) * Convert.ToDouble(Value2);

            return SummValue;
        }
    }
}
