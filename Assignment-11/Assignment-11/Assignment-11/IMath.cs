using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    public interface IMath<T> where T : class
    {
        //public int Value1 { get; set; }
        //public int Value2 { get; set; }
        double AddValues(T Value1, T Value2);
        double SubstractValues(T Value1, T Value2);
        double MultiplyValues(T Value1, T Value2);

    }
}
