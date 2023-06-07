//2.გამყოფების რაოდენობა
Console.WriteLine("Sheikvanet ricxvi: ");
int userInput = Convert.ToInt32(Console.ReadLine());

int i, Sum = 0;

for (i = 1; i <= userInput; i++)
{
    if (userInput % i == 0)
    {
        Sum = ++Sum;
        Console.WriteLine("gamkofebi: " + i);
    }
}
Console.WriteLine("gamkofebis raodenoba: " + Sum);