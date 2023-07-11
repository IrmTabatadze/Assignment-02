using Task2;

string[] strings = { "Name", "Name and Full Name", "Age" };
Console.WriteLine("airchiet filtri '0', '1' , '2' ");

for (int i = 0; i < strings.Length; i++)
{
    Console.WriteLine($"{i} {strings[i]}");
}

var Filter = Console.ReadLine();
if (Filter == "0")
{
    Console.WriteLine("sheikvanet saxeli: ");
    var FilterName = Console.ReadLine();

    var Result = new DelegateNameSerch(SearchFile.SearchUser);
    Result(FilterName);
}
else if (Filter == "1")
{
    Console.WriteLine("sheikvanet saxeli: ");
    var FilterName = Console.ReadLine();

    Console.WriteLine("sheikvanet gvari: ");
    var FilterFullName = Console.ReadLine();

    var Result = new DelegateNameAndFullNameSerch(SearchFile.SearchUser);
    Result(FilterName, FilterFullName);
}
else if (Filter == "2")
{
    Console.WriteLine("sheikvanet asaki");
    var FilterAge = Convert.ToInt32(Console.ReadLine());

    var Result = new DelegateAgeSerch(SearchFile.SearchUser);
    Result(FilterAge);
}



public delegate string DelegateNameAndFullNameSerch(string Name, string FulName);
public delegate string DelegateNameSerch(string Name);
public delegate string DelegateAgeSerch(int Name);