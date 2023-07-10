using System.Diagnostics;
using System.Reflection;
using System.Security.AccessControl;
using Task1;

Console.WriteLine("airchiet operacia 'A' or 'B'");
var Operation = Console.ReadLine();

if (Operation == "A")
{
    Console.WriteLine("sheikvanet ricxvi 1: ");
    var Number1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("sheikvanet ricxvi 2: ");
    var Number2 = Convert.ToDouble(Console.ReadLine());

    var NumberOperation = new NumberOperation();

    try
    {
        Type MyClassType = NumberOperation.CreateAssemblyAndClassType();
        object MyInstance = NumberOperation.CreateInstance(MyClassType);

        double result = NumberOperation.Subtract(MyClassType, MyInstance, Number1, Number2);
        double result2 = NumberOperation.Plus(MyClassType, MyInstance, Number1, Number2);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception: " + ex.Message);
    }

}
else
{
    Console.WriteLine($"Sheikvanet manqanis tipi 'Off road', 'Sedan', 'Construction', 'Public'");
    string cartype = Console.ReadLine();

    var StringOperation = new StringOperation();

    try
    {
        Type MyClassType = StringOperation.CreateAssemblyAndClassType();
        Object MyInstance = StringOperation.CreateInstance(MyClassType);

        StringOperation.ReturnCarType(MyClassType, MyInstance, cartype);
        StringOperation.ReturnCarTire(MyClassType, MyInstance, cartype);
    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

