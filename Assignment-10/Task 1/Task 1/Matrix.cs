using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Matrix
    {
        public Matrix(double a1, double a2, double a3, double a4)
        {
            A1 = a1;
            A2 = a2;
            A3 = a3;
            A4 = a4;
        }

        public Matrix(double [,] arr)
        {
            A1 = arr[0,0];
            A2 = arr[0,1];
            A3 = arr[1,0];
            A4 = arr[1,1];
        }

        public Matrix()
        {
        }

        public double A1 { get; set; }
        public double A2 { get; set; }
        public double A3 { get; set; }
        public double A4 { get; set; }

        public static Matrix operator +(Matrix Array1, Matrix Array2)
        {
            var Array3 = new Matrix();

            if (Array1 == null)
                throw new ArgumentNullException(nameof(Array1));
            if (Array2 == null)
                throw new ArgumentNullException(nameof(Array2));
            else
            {
                Array3.A1 = Array1.A1 + Array2.A1;
                Array3.A2 = Array1.A2 + Array2.A2;
                Array3.A3 = Array1.A3 + Array2.A3;
                Array3.A4 = Array1.A4 + Array2.A4;
                return Array3;

            }
        }

        public static Matrix operator -(Matrix Array1, Matrix Array2)
        {
            var Array3 = new Matrix();

            if (Array1 == null)
                throw new ArgumentNullException(nameof(Array1));
            if (Array2 == null)
                throw new ArgumentNullException(nameof(Array2));
            else
            {
                Array3.A1 = Array1.A1 - Array2.A1;
                Array3.A2 = Array1.A2 - Array2.A2;
                Array3.A3 = Array1.A3 - Array2.A3;
                Array3.A4 = Array1.A4 - Array2.A4;
                return Array3;
            }
        }

        public static Matrix operator -(Matrix Array1)
        {
            var MyOverrideOperators = new Matrix();

            if (Array1 == null)
                throw new ArgumentNullException(nameof(Array1));
            
            else
            {
                MyOverrideOperators.A1 = -Array1.A1 ;
                MyOverrideOperators.A2 = -Array1.A2 ;
                MyOverrideOperators.A3 = -Array1.A3;
                MyOverrideOperators.A4 = -Array1.A4 ;
                return MyOverrideOperators;
            }
        }
        public override bool Equals(object Array1)
        {
            if (Array1 == null)
            {
                return false;
            }
            if (!(Array1 is Matrix))
            {
                return false;
            }
               return (this.A1 == ((Matrix)Array1).A1)
                && (this.A2 == ((Matrix)Array1).A2); ;

        }

        public override int GetHashCode()
        {
            return A1.GetHashCode() ^ A2.GetHashCode();
        }

        public override string ToString()
        {
            return $"{this.A1} {A2}";
        }

    }
}

