using Task1;

string[] strings = { "Plus", "Multiply", "Sqrt" };
Console.WriteLine("airchiet matematikuri operacia: {0}");

for (int i = 0; i < strings.Length; i++)
{
    Console.WriteLine($"{i+1} - " + strings[i]);
}

var Operation = Console.ReadLine();

if (Operation == null)
{
    Console.WriteLine("oreaciis archeva aucilebelia, catet tavidan!");
}
else if (Operation == "Plus")
{
    Console.WriteLine("ricxvi 1:");
    double Number1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("ricxvi 2:");
    double Number2 = Convert.ToDouble(Console.ReadLine());
    
    var DelResult = new DelegateCalcOperation(Calculator.Plus); //Plus
    DelResult(Number1, Number2);
}

else if (Operation == "Multiply")
{
    Console.WriteLine("ricxvi 1:");
    double Number1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("ricxvi 2:");
    double Number2 = Convert.ToDouble(Console.ReadLine());

    var DelResult = new DelegateCalcOperation(Calculator.MathOperation); //Multiply
    DelResult(Number1, Number2);

}

else if (Operation == "Sqrt")
{
    Console.WriteLine("ricxvi 1:");
    double Number = Convert.ToDouble(Console.ReadLine());
    var DelResult = new DelegateCalcOperationSqrt(Calculator.MathOperation); //Sqrt
    DelResult(Number);
}

















public delegate double DelegateCalcOperation(double Number1, double Number2);
public delegate double DelegateCalcOperationSqrt(double Number1);
