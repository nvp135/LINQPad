<Query Kind="Statements" />

string[] names = {"Alex", "Otto", "Francoi", "Diego", "Gabi", "Gas" };

var query = from name in names
	group name by name.Length;
	
IEnumerable<IGrouping<int, string>> query1 =
	names.GroupBy(name => name.Length);

var query2 = from name in names
	group name.ToUpper() by name.Length;

var query3 = names.GroupBy(
	name => name.Length,
	name => name.ToUpper());
	
var query4 = from name in names
	group name.ToUpper() by name.Length into grouping
	orderby grouping.Key
	select grouping;
	
var query5 = from name in names
	group name.ToUpper() by name.Length into grouping
	where grouping.Count() == 3
	select grouping;

foreach(IGrouping<int, string> grouping in query4)
{
	Console.Write("\r\nLength=" + grouping.Key + ":");
	foreach(string name in grouping)
		Console.Write(" " + name);
}

