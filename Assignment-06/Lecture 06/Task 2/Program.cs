
using System.Timers;
using System.Xml.Linq;
using Task_2;

var list = new CustomList();

list.AddElement(new List("1", "1"));
list.AddElement(new List("2", "2"));
list.AddElement(new List("3", "3"));
list.AddElement(new List("4", "4"));
list.AddElement(new List("5", "5"));
list.AddElement(new List("6", "6"));

list.OutputElements();

list.InsertElement(5, new List("new", "new"));

list.OutputElements();

var newlist = new CustomList();

newlist.AddElement(new List("a", "a"));
newlist.AddElement(new List("b", "b"));
newlist.AddElement(new List("c", "c"));
newlist.AddElement(new List("d", "d"));
newlist.AddElement(new List("e", "e"));
list.OutputElements();

list.AddElementList(newlist);
list.OutputElements();


list.GetElement(6, out var element);
list.OutputElements();

list.RemoveElement(4);
list.OutputElements();

list.RemoveList(3, 3);
list.OutputElements();


list.InsertList(3, newlist);
list.OutputElements();

Console.WriteLine();


Console.WriteLine("\narcheuli elementi: " + element.Name);

list.GetList(2, 3, out var subList);
subList.OutputElements();

Console.WriteLine();

Console.WriteLine("\nmodzebnili elementi: " + list.Find("1").Name);
Console.WriteLine("-------------------------");
Console.WriteLine("\nelementebis raodenoba: " + list.Count);


