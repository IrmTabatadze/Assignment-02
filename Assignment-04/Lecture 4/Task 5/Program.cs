// 5
Console.WriteLine("Sheikvanet masivis zoma :");

int n = int.Parse(Console.ReadLine());
int[,] l = new int[n, n];

Console.WriteLine("\n" + "sheikvanet masivis elementebi: ");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        l[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\n"+"dagenerirebuli masivi: ");

for (int i = 0; i < n; i++)
{
    Console.WriteLine();

    for (int j = 0; j < n; j++)
    {
        Console.Write("{0}\t", l[i, j]);
    }
}

Console.WriteLine("\n"+ "Determinant is: " + Determinant(l) ); 

static double Determinant(int[,] l)
{
    int order = int.Parse(System.Math.Sqrt(l.Length).ToString());
    if (order == 2)
    {
        return ((l[0, 0] * l[1, 1]) - (l[1, 0] * l[0, 1]));
    }
    else if (order == 3)
    {
        double value = 0;
        for (int i = 0; i < order; i++)
        {
            value = value + +(l[0, i] * (l[1, (i + 1) % 3] * l[2, (i + 2) % 3] - l[1, (i + 2) % 3] * l[2, (i + 1) % 3]));
        }
        return value;
    }
    else
    {
        return ((l[0, 0]));
    }
}

