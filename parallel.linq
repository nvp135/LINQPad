<Query Kind="Statements" />

var list = new List<int> {12,5,56,6,7,8,78};
var list1 = list.AsParallel().OrderBy(x => x).AsOrdered();
foreach(var elem in list1)
{
	Console.WriteLine(elem);
}