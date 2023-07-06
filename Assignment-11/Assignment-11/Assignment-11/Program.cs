using Assignment_11;

var OperatorClass = new OperatorClass<BaseClass<int>>();
var value1 = new BaseClass<int>();
var value2 = new BaseClass<int>();
value1.SaveValue(20);
value2.SaveValue(15);

var value4 = value1.GetValue1();
var value5 = value2.GetValue1();
Console.WriteLine(value4);
//var res = OperatorClass.AddValues(value1, value2);
//Console.WriteLine(res);

///*OperatorClass*/<int> a = new OperatorClass<int>();
//double res1 = a.AddValues(23, 48);
//Console.WriteLine(res1);

