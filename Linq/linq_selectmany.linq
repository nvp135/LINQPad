<Query Kind="Statements" />

int[] numbers = {1, 2, 3, 4, 5};
string[] letters = {"а", "б", "в"};

var query = from n in numbers
			from l in letters
			select n.ToString() + l;

foreach(var s in query)
{
	Console.WriteLine(s); 
}

Console.WriteLine("*****");

var query1 = numbers.SelectMany(
	n => letters,
	(n, l) => (n.ToString() + l));
	
foreach(var s in query1)
{
	Console.WriteLine(s); 
}