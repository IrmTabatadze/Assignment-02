//4.პირამიდის სართულები
Console.WriteLine("Sheikvanet ricxvi: ");
int userInput = Convert.ToInt32(Console.ReadLine());

int i, j = 0;
string Snowflake = "*";

for (i = 1; j <= userInput; i++)
{
    if (i == 1)
    {
        Console.WriteLine(Snowflake);
        j++;
    }

    else if (i > 1)
    {
        Snowflake = Snowflake + "**";
        Console.WriteLine(Snowflake);
    }
    i++;
    j++;

}