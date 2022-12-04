<Query Kind="Statements" />

string[] names = {"Олег", "Алексей", "Евгений", "Василий", "Андрей"};
IEnumerable<string> query = 
	from n in names
	let vowelless = Regex.Replace(n, "[аоиеёэыуюя]", "")
	where vowelless.Length > 3
	orderby vowelless
	select n + " - " + vowelless;
	
foreach(var s in query)
{
	Console.WriteLine(s);
}

IEnumerable<string> query1 = names.
	Select( n => new 
		{
			n = n,
			vowelless = Regex.Replace(n, "[аоиеёэыуюя]", "")
		}
	)
	.Where(temp0 => (temp0.vowelless.Length > 2 ))
	.OrderBy(temp0 => temp0.vowelless)
	.Select(temp0 => (temp0.n + "-") + temp0.vowelless);

Console.WriteLine("*****");

foreach(var s in query)
{
	Console.WriteLine(s);
}