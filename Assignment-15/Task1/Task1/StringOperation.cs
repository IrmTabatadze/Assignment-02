using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class StringOperation
    {
        public static Type CreateAssemblyAndClassType()
        {
            var MyAssembly = Assembly.LoadFile(@"C:\Users\IrmTabatadze\Desktop\Irma\Assignment-02\Assignment-15\Task1\StringLibrary\bin\Debug\net6.0\StringLibrary.dll");

            Type MyClassType = MyAssembly.GetType("StringLibrary.CarClass");

            return MyClassType;

        }
        public static object CreateInstance(Type MyClassType)
        {
            object MyInstance = Activator.CreateInstance(MyClassType);
            return MyInstance;
        }
        public void CarClass(Type MyClassType, object MyInstance, string CarName)
        {
            var Result = MyClassType.InvokeMember("CarClass", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                                        null, MyInstance, new object[] { CarName });
            Console.WriteLine(Result);
           if (Result == null )
            {
                Console.WriteLine("car is empty!");

            }
            else
            {
                Console.WriteLine(Result);
            }
           
        }

        public void GetCarType(Type MyClassType, object MyInstance, string CarType)
        {
            var Result = MyClassType.GetProperty("Type");
            Console.WriteLine(Result);

        }

        public void GetCarColor(Type MyClassType, object MyInstance, string CarColor)
        {
            var Result = MyClassType.GetProperty("Color");
            Console.WriteLine(Result.GetValue(MyInstance, null));
            Result.SetValue(MyInstance, CarColor); 

            //Console.WriteLine();
        }
        public void ReturnCarType(Type MyClassType, object MyInstance, string cartype)
        {
            var Result = MyClassType.InvokeMember("ReturnCarType", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                                        null, MyInstance, new object[] { cartype });
            Console.WriteLine("\nCar Type: " + Result);

        }

        public void ReturnCarTire(Type MyClassType, object MyInstance, string cartype)
        {
            var Result = MyClassType.InvokeMember("ReturnCarTire", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                                       null, MyInstance, new object[] { cartype });
            Console.WriteLine("\nCar Tire: " + Result);
        }
    }
}
