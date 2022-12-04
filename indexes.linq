<Query Kind="Statements" />

var rnd = new Random();
List<int> numbers = new List<int>();
for(int i = 0; i < 55; i++)
{
	numbers.Add(rnd.Next(0,100));
}
//var numbers = new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
var evenFibs = numbers
    .Where(f => (f % 2) == 0)
    .Select((f, index) => new { Number = f, Index = index })
    .ToList();
	
foreach(var i in evenFibs)
Console.WriteLine(i);