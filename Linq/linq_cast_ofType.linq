<Query Kind="Program" />

void Main()
{
	ArrayList arrayList = new ArrayList();
	arrayList.Add("Vasya");
	arrayList.Add("Petya");
	arrayList.Add("Vitunya");
	/*IEnumerable<string> names = arrayList.Cast<string>().Where(n => n.Length < 7);
	foreach(var name in names)
		Console.WriteLine(name);*/
	IEnumerable<string> names = arrayList.OfType<string>().Where(n => n.Length < 7);
	foreach(var name in names)
		Console.WriteLine(name);
}

// Define other methods and classes here
