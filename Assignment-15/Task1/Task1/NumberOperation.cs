using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class NumberOperation
    {
        public static Type CreateAssemblyAndClassType()
        {
            var MyAssembly = Assembly.LoadFile(@"C:\Users\IrmTabatadze\Desktop\Irma\Assignment-02\Assignment-15\Task1\ClassLibrary\bin\Debug\net6.0\ClassLibrary.dll");

            Type MyClassType = MyAssembly.GetType("ClassLibrary.Class");
           
            return MyClassType;

        }

        public static object CreateInstance(Type MyClassType)
        {
            object MyInstance = Activator.CreateInstance(MyClassType);
            return MyInstance;
        }

        public static double Subtract(Type MyClassType, object MyInstance, double Number1, double Number2)
        {
            var SubtractResult = MyClassType.InvokeMember("Subtract", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                                                    null, MyInstance, new object[] { Number1, Number2 });

            Console.WriteLine("\nSubtract Result: " + SubtractResult);

            return (double)SubtractResult;
        }

        public static double Plus(Type MyClassType, object MyInstance, double Number1, double Number2)
        {
            var PlussResult = MyClassType.InvokeMember("Plus", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                                                            null, MyInstance, new object[] { Number1, Number2 });
            Console.WriteLine("\nPlus Result: " + PlussResult);
           
            return (double)PlussResult;
        }
    }
}
