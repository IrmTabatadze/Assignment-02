using System;
using Task_1;

double[,] Array1 = new double[2, 2];
double[,] Array2 = new double[2, 2];
Console.WriteLine("\n" + "sheikvanet masivis elementebi: ");

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Array1[i, j] = double.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\n" + "sheikvanet masivis elementebi: ");

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Array2[i, j] = double.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 2; i++)
{
    Console.WriteLine();

    for (int j = 0; j < 2; j++)
    {
        Console.Write("{0}\t", Array1[i, j]);
    }
}

Console.WriteLine("\n");

for (int i = 0; i < 2; i++)
{
    Console.WriteLine();

    for (int j = 0; j < 2; j++)
    {
        Console.Write("{0}\t", Array2[i, j]);
    }
}

Console.WriteLine("\n");

var v1 = Array1[1, 1];
var v2 = Array2[1, 0];

Console.WriteLine( v1.Equals(v2));

var Over1 = new Matrix(Array1);
var Over2 = new Matrix(Array2);

var Over3 = Over1 + Over2;
Console.WriteLine("\njami: " + $"{Over3.A1} , {Over3.A2}, {Over3.A3}, {Over3.A4}");

var Over4 = Over1 - Over2;

var d2 = (double)Array1[0, 0];
