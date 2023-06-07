
//მომხმარებლის დაბადების წელი
Console.WriteLine("Sheikvanet dabadbeis weli: ");
string userYear = Console.ReadLine();

int userYearForInt = Convert.ToInt32(userYear);

string astro_sign = "";

if ((userYearForInt - 2000) % 12 == 0)
{
    astro_sign = "drakoni";
}

else if ((userYearForInt - 2000) % 12 == -11 || (userYearForInt - 2000) % 12 == 1)
{
    astro_sign = "gveli";
}

else if ((userYearForInt - 2000) % 12 == -10 || (userYearForInt - 2000) % 12 == 2)
{
    astro_sign = "cxeni";
}

else if ((userYearForInt - 2000) % 12 == -9 || (userYearForInt - 2000) % 12 == 3)
{
    astro_sign = "txa";
}
else if ((userYearForInt - 2000) % 12 == -8 || (userYearForInt - 2000) % 12 == 4)
{
    astro_sign = "maimuni";
}

else if ((userYearForInt - 2000) % 12 == -7 || (userYearForInt - 2000) % 12 == 5)
{
    astro_sign = "mamali";
}

else if ((userYearForInt - 2000) % 12 == -6 || (userYearForInt - 2000) % 12 == 6)
{
    astro_sign = "dzagli";
}

else if ((userYearForInt - 2000) % 12 == -5 || (userYearForInt - 2000) % 12 == 7)
{
    astro_sign = "gori";
}

else if ((userYearForInt - 2000) % 12 == -4 || (userYearForInt - 2000) % 12 == 8)
{
    astro_sign = "virtxa";
}

else if ((userYearForInt - 2000) % 12 == -3 || (userYearForInt - 2000) % 12 == 9)
{
    astro_sign = "xari";
}

else if ((userYearForInt - 2000) % 12 == -2 || (userYearForInt - 2000) % 12 == 10)
{
    astro_sign = "vefxvi";
}

else if ((userYearForInt - 2000) % 12 == -1 || (userYearForInt - 2000) % 12 == 11)
{
    astro_sign = "kurdgeli";
}

Console.WriteLine(astro_sign);

