//ვერ გავაკეთე
Console.WriteLine("SeiyvaneT masivis zoma: ");
int arraylength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("SeiyvaneT masivis elementebi: ");
int[] myarray = new int[arraylength];
for (int i = 0; i < arraylength; i++)
{
    myarray[i] = Convert.ToInt32(Console.ReadLine());
}


int[] totalarray = new int[arraylength];

int j = 1, locvar;
 

for (int i = 0; i < arraylength; i++)
{
    if (myarray[i] <= myarray[j])
    {
        locvar = myarray[i];
        totalarray[i] = locvar;
        j++;
    }

    //else if (locvar <= myarray[j])
    //{
    //    locvar = (int)myarray[j];
    //}
}

Console.WriteLine("\n" + "masivi: ");
for (int i = 0; i < arraylength; i++)
{
    Console.WriteLine(totalarray[i]);
}
