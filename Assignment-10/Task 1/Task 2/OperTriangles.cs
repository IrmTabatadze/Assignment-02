using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;

namespace Task_2
{
    public class OperTriangles
    {
        public OperTriangles(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public OperTriangles() 
        { 
        }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Perimeter { get; set; }
        public double Area { get; set; }

        public static bool operator ==(OperTriangles triagle1, OperTriangles triagle2)
        {
            return triagle1.Side1 == triagle2.Side1 && triagle1.Side2 == triagle2.Side2 && triagle1.Side3 == triagle2.Side3;
        }

        public static bool operator !=(OperTriangles triagle1, OperTriangles triagle2)
        {
            return triagle1.Side1 == triagle2.Side1 && triagle1.Side2 == triagle2.Side2 && triagle1.Side3 == triagle2.Side3;
        }
       
        public static bool operator <(OperTriangles triagle1, OperTriangles triagle2)
        {
            return Math.Sqrt(Math.Pow(triagle1.Area, 2))
                < Math.Sqrt(Math.Pow(triagle2.Area, 2));
        }
        public static bool operator >(OperTriangles triagle1, OperTriangles triagle2)
        {
            return Math.Sqrt(Math.Pow(triagle1.Area, 2))
                > Math.Sqrt(Math.Pow(triagle2.Area, 2));
        }

        public static OperTriangles operator +(OperTriangles area1, OperTriangles area2)
        {
            var triangle1 = new OperTriangles();
            triangle1.Area = area1.Area + area2.Area;
            var Side = triangle1.Area / 3;

            return new OperTriangles(Side, Side, Side);
        }

        public static explicit operator OperTriangles(double d)
        {
            return new OperTriangles(d, d, d); 
        }
    }
}
