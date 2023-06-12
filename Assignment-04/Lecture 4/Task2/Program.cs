// Task 2
//array 1: apple, cat, car

//array 2: 1, 5, 2
//result: apple 1, car 5, car 2

Console.Write("Sheiyvanet masivis zoma :");
int arrayleng = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sheikvanet masivis elementebi : ");
 

string[] myarray = new string[arrayleng];

for (int i = 0; i < arrayleng; i++)
{
    Console.WriteLine(myarray[i]);
    myarray[i] = Console.ReadLine();
}


Console.Write("Sheiyvanet meore masivis zoma :");
int secondarrayleng = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sheikkvanet elementebis raodenoba : ");
string[] secondarray = new string[secondarrayleng];

for(int i = 0;i < secondarrayleng; i++)
{
    Console.WriteLine(secondarray[i]);
    secondarray[i] = Console.ReadLine();
}


string[] totalarray = new string[arrayleng];

for (int i = 0; i < arrayleng; i++)
{
    totalarray[i] = myarray[i] + secondarray[i];
    Console.WriteLine(totalarray[i]);
}


