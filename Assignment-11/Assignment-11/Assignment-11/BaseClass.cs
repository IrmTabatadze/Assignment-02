using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    public class BaseClass<T>
    {
        private T _value;
        //private T _value2;
        public void SaveValue(T Value) 
        {
            _value = Value;
            //_value2 = Value2;
                
        }

        public T GetValue1() 
        { 
            return _value; 
        }
        //public T GetValue2()
        //{
        //    return _value2;
        //}
    }
}
