
using Task_2;

Console.WriteLine("sheikvanet samkutxedis gverdebi");
double side1 = Convert.ToDouble(Console.ReadLine());
double side2 = Convert.ToDouble(Console.ReadLine());
double side3 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("sheikvanet samkutxedis gverdebi");
double side4 = Convert.ToDouble(Console.ReadLine());
double side5 = Convert.ToDouble(Console.ReadLine());
double side6 = Convert.ToDouble(Console.ReadLine());


var Triangle = new Triangle();
double Perimeter1 = Triangle.Perimeter(side1, side2, side3);
Console.WriteLine("pirveli samkuTxedis perimetria: " + Perimeter1);

double Perimeter2 = Triangle.Perimeter(side4, side5, side6);
Console.WriteLine("meore samkuTxedis perimetria: " + Perimeter2);

var Perimeter3 = Triangle.Perimeter(side1, side2, side3) + Triangle.Perimeter(side4, side5, side6);

Console.WriteLine(Perimeter3);

var area1 = Triangle.Area(side1, side2, side3);
Console.WriteLine("pirveli samkuTxedis fartobi: " + area1);
var area2 = Triangle.Area(side2, side1, side3);
Console.WriteLine("meore samkuTxedis fartobi: " + area2);


var Triangle1 = new OperTriangles();
var Triangle2 = new OperTriangles();
Triangle1.Side1 = side1;
Triangle1.Side2 = side2;
Triangle1.Side3 = side3;
Triangle2.Side1 = side4;
Triangle2.Side2 = side5;
Triangle2.Side3 = side6;
Triangle1.Area = Triangle.Area(Triangle1.Side1, Triangle1.Side2, Triangle1.Side3);
Triangle2.Area = Triangle.Area(Triangle2.Side1, Triangle2.Side2, Triangle2.Side3);
Console.WriteLine(Triangle1 > Triangle2);

Console.WriteLine(Triangle1 != Triangle2);
Console.WriteLine(Triangle1 == Triangle2);

var Triangle3 = new OperTriangles();
Triangle3 = Triangle1 + Triangle2;

Console.WriteLine($"side1: {Triangle3.Side1} sm, side2: {Triangle3.Side2} sm, side3: {Triangle3.Side3}sm");

Console.WriteLine("samkutxedi aris tu ara tolgverda : " + Triangle.EquilateralTriangle(side1, side2, side3));

var triangle = (OperTriangles)6;
Console.WriteLine($"side1: {triangle.Side1} sm, side2: {triangle.Side2} sm, side3: {triangle.Side3}sm");

var triangle3 = Triangle.Area(side1, side2, side3) + Triangle.Area(side2, side1, side3);



