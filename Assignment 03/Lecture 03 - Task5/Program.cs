
//5.random რიცხვით თამაში
Console.WriteLine("Sheikvanet min ricxvi: ");
int MinInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sheikvanet max ricxvi: ");
int MaxInput = Convert.ToInt32(Console.ReadLine());

var random = new Random();
int ran = random.Next(MinInput, MaxInput);

Console.WriteLine("Sheikvanet ricxvi: ");
int userInput = Convert.ToInt32(Console.ReadLine());

int j = 1;
while (1 == 1)
{
    if (userInput == ran)
    {
        Console.WriteLine("rendom ricxvi iko : " + ran);
        Console.WriteLine("mcdeloba: " + j);
        Console.WriteLine("gavagrZeloT Tamashi?");
        string Answer = Console.ReadLine();
        if (Answer == "NO")
        {
            break;
        }
        else
        {
            Console.WriteLine("Sheikvanet min ricxvi: ");
            MinInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sheikvanet max ricxvi: ");
            MaxInput = Convert.ToInt32(Console.ReadLine());

            random = new Random();
            ran = random.Next(MinInput, MaxInput);
            Console.WriteLine("Sheikvanet ricxvi: ");
            userInput = Convert.ToInt32(Console.ReadLine());
        }


    }
    else if (userInput != ran)
    {
        Console.WriteLine("Sheikvanet ricxvi: ");
        userInput = Convert.ToInt32(Console.ReadLine());
        j++;
        continue;

    }

}
Console.WriteLine("mcdeloba: " + j);