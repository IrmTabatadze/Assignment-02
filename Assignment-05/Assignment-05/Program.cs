//1
Console.WriteLine("Sheikvanet masivis sigrdze:");
int arrayleng = Convert.ToInt32(Console.ReadLine());

string[] myarray = new string[arrayleng];
Console.WriteLine("\n" + "Sheikvanet masivis elementebi");

for (int i = 0; i < arrayleng; i++)
{
    myarray[i] = Console.ReadLine();
}

Console.WriteLine("\n" + "Sheikvanet indeqsi:");

int index = Convert.ToInt32(Console.ReadLine());
int userchoice;

if (index > arrayleng-1)
    {
    Console.WriteLine("\n" + "indeqsi metia masivis sigrdzeze!!! Sheikvanet axali indeqsi: ");
    Console.WriteLine("\n" + "Sheikvanet indeqsi:");

    index = Convert.ToInt32(Console.ReadLine());

    userchoice = int.Parse(myarray[index]);

    Console.Write("\n" + "archeuli ricxvi = " + userchoice);
    Console.Write("\n" + "jami = " + userdigitsum(userchoice) + "\n");
}
else    
    { 
    userchoice = int.Parse(myarray[index]);

    Console.Write("\n" + "archeuli ricxvi = " + userchoice);
    Console.Write("\n" + "jami = " + userdigitsum(userchoice) + "\n");
    }

string userdigitsum(int userchoice)
{
    int sum = 0, m;

    while (userchoice > 0)
    {
        m = userchoice % 10;
        sum = sum + m;
        userchoice = userchoice / 10;
    }

    return Convert.ToString(sum);
}
