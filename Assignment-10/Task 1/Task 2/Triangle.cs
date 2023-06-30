using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Triangle
    {
        public static double Area(double side1, double side2, double side3)
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public static double Perimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }

        public static bool EquilateralTriangle(double side1, double side2, double side3)
        {
            if (side1 == side2)
            {
                return true;
            }
            else if (side1 == side3)
            {
                return true;

            }
            else if (side2 == side3)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
