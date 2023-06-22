using System.Text.RegularExpressions;
using Task_1;

int FirsNumber, SecondNumber, UserPow;
Console.WriteLine("Sheikvanet pirveli ricxvi: ");
FirsNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sheikvanet meore ricxvi: ");
SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add - : " + Calculator.AddNumbers(FirsNumber, SecondNumber));
Console.WriteLine("Subtract - : " + Calculator.Subtract(FirsNumber, SecondNumber));
Console.WriteLine("Multiply - : " + Calculator.Multiply(FirsNumber, SecondNumber));
Console.WriteLine("Divide - : " + Calculator.Divide(FirsNumber, SecondNumber));

Console.WriteLine("\nSheikvanet ricxvi: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sheikvanet xarisxis machvenebeli: ");
UserPow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pow - : " + Calculator.Pow(Number, UserPow));

Console.WriteLine("\nromeli ricxvis fesvi gainteresebt? ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sqrt - : " + Calculator.Sqrt(UserNumber));
