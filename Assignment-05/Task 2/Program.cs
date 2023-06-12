//2

Console.WriteLine("Sheikvanet masivis sigrdze:");
int arrayleng = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n" + "Sheikvanet masivis elementebi:");

char[] chararray = new char[arrayleng];

for (int i = 0; i < arrayleng; i++)
{
    chararray[i] = Convert.ToChar(Console.ReadLine());

}

Console.WriteLine("\n" + "sheikvanet romeli simbolo moidzebnos:");
char usersimbol = Convert.ToChar(Console.ReadLine());

Console.WriteLine("\n" + "masivis elementebi:");
for (int i = 0; i < arrayleng; i++)
{
    Console.WriteLine(chararray[i]);
}

string strcount = findsimbols(chararray, usersimbol);

Console.WriteLine("raodeniba: " + strcount);
Console.WriteLine(printsimbolscount(usersimbol, strcount));

string findsimbols(char[] chararray, char usersimbol)
{
    int sum = 0;
    for (int i = 0;i < chararray.Length;i++)
    {
        if (chararray[i] == usersimbol)
            {
            sum = sum + 1;
            }
    }

    return Convert.ToString(sum);
}

string printsimbolscount(char usersimbol, string strcount)
{
    return "simbolo '" + usersimbol + "' Shegvxvda " + strcount;
}
