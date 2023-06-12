//3 ASC / DESC
string mySortKey;

int[] FirstArray = new int[5];
Console.WriteLine("Sheikvanet masivis elementebi: ");

for (int i = 0; i < 5; i++)
{
    FirstArray[i] = Convert.ToInt32(Console.ReadLine());
}

int[] SecondArray = new int[5];
Console.WriteLine("Sheikvanet masivis elementebi: ");

for (int i = 0; i < 5; i++)
{
    SecondArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("dalagebis mimartuleba, ASC / DESC");
mySortKey = Console.ReadLine();


int[] TertiaryArray = new int[10];

for (int i = 0; i < 5; i++)
{
    TertiaryArray[i] = FirstArray[i];
}

int j = 0;
for (int i = 5; i < 10; i++)
{
    TertiaryArray[i] = SecondArray[j];
    j ++;
}


if (mySortKey == "ASC") 
{ 
    Array.Sort(TertiaryArray);

    foreach (int i in TertiaryArray)
    {
        Console.WriteLine(i);
    }

}

else if (mySortKey == "DESC")
{
    Array.Reverse(TertiaryArray);

    foreach(int i in TertiaryArray)
    { 
        Console.WriteLine(i); 
    }
}

