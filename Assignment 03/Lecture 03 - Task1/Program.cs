//მარტივი რიცხვები
int userinput, i, m = 0, flag = 0;

Console.Write("Seikvanet ricxvi: ");

userinput = int.Parse(Console.ReadLine());

m = userinput / 2;

for (i = 2; i <= m; i++)
{
    if (userinput % i == 0)
    {
        Console.Write("shekvanili mnishvneloba shedgenilia.");
        flag = 1;
        break;
    }
}
if (flag == 0)
    Console.Write("shekvanili mnishvneloba martivia.");
