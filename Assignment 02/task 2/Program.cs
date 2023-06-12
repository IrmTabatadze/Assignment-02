//ტემპერატურა
Console.WriteLine("Write ypur celsius");
String usercelsius = Console.ReadLine();

int celsius = Convert.ToInt32(usercelsius);

if (celsius < 0)
{
    Console.WriteLine("its freezing");
}
else if (celsius > 0 && celsius < 30)
{
    Console.WriteLine("weather is good");
}
else
{
    Console.WriteLine("it's hot");
}