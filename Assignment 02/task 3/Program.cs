////ჯეირანი
Console.WriteLine("write qva,makrateli or qagaldi");
String UserInput = Console.ReadLine();

if (UserInput == "")
{
    Console.WriteLine("input is empty!");
    return;
}

var random = new Random();
int randNumber = random.Next(0, 2);

switch (UserInput)
{
    case "qva" when (randNumber == 0):
        Console.WriteLine("fre");
        break;
    case "qva" when (randNumber == 1):
        Console.WriteLine("waage");
        break;
    case "qva" when (randNumber == 2):
        Console.WriteLine("moige");
        break;

    case "qagaldi" when (randNumber == 0):
        Console.WriteLine("moige");
        break;
    case "qagaldi" when (randNumber == 1):
        Console.WriteLine("fre");
        break;
    case "qagaldi" when (randNumber == 2):
        Console.WriteLine("waage");
        break;

    case "makrateli" when (randNumber == 0):
        Console.WriteLine("waage");
        break;
    case "makrateli" when (randNumber == 1):
        Console.WriteLine("moige");
        break;
    case "makrateli" when (randNumber == 2):
        Console.WriteLine("fre");
        break;

}
if (randNumber == 0)
{
    Console.WriteLine("qva");
}
else if (randNumber == 2)
{
    Console.WriteLine("makrateli");
}
else if (randNumber == 1)
{
    Console.WriteLine("qagaldi");
}
