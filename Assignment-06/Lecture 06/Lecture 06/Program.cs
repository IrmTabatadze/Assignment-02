
using LibrarySystem;


Library lib = new Library();

lib.AddBook(new Book("shashvi shashvi makvali", "Tamta melashvili", 2020, "romani"));
lib.AddBook(new Book("ukmari sinatle", "nino kharatishvili", 2021, "romani"));
lib.AddBook(new Book("mrude saxli", "agata kristi", 2021, "deteqtivi"));
lib.AddBook(new Book("gmerti samsaxurshia", "dato gorgiladze", 2018, "romani"));
lib.AddBook(new Book("sarchuli da piri", "alber kamiu", 1935, "romani"));
lib.AddBook(new Book("mze mtvare da puris kana", "temur babluani", 2015, "drama"));
lib.AddBook(new Book("oskari da vardiferi qalbatoni", "erik-emanuel shmiti", 2018, "romani"));

Console.WriteLine("biblioteka: ---------------------");

for (int i = 0; i < lib.Count; i++)
{
    Console.Write("{" + i +"} \t");
        lib[i].BookInfo();
}

Console.WriteLine("\n" + "modzebnili wigni: ");
lib.FindBook("oskari da vardiferi qalbatoni");

lib.RemoveBook(4);
lib.RemoveBookWhitName("ukmari sinatle");
Console.WriteLine("\n" + "washlis shemdeg darchenili biblioteka: ---------------------");


for (int i = 0; i < lib.Count; i++)
{
    Console.Write("{" + i + "} \t");
    lib[i].BookInfo();
}    

//int counte = lib.Count;
//for (int i = 0; i < counte; i++)
//{
//    Console.WriteLine($"{lib[i].Title} - {lib[i].Author} - {lib[i].Year}- {lib[i].Genre}");
//}


//Console.WriteLine("sheikvanet wignis parametrebi: ");

//WriteBooksOnLibrary();

//void WriteBooksOnLibrary()
//{
//    Book book = new Book();
//    Console.Write("title - ");
//    book.Title = Console.ReadLine();

//    Console.Write("author - ");
//    book.Author = Console.ReadLine();

//    Console.Write("year - ");
//    book.Year = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Genre - ");
//    book.Genre = Console.ReadLine();


//    lib.AddBook(book);
//}


//Console.WriteLine("Sheikvant sxva wigns? Y/N");
//if (Console.ReadLine() == "Y")
//{
//    WriteBooksOnLibrary();
//}

//Console.WriteLine(lib[0]);



