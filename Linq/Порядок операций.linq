<Query Kind="Program" />

void Main()
{
	var query1 = Enumerable.Range(1, 30);
	
	var query2 = query1
					.Where(x => x > 1).Dump("Where")
					.Select(x => x + 1).Dump("Select")
					.ToList();
}


public static class MyExtention {
	public static IEnumerable<T> Dump<T>(this IEnumerable<T> source, string text) 
	{
	  foreach(var item in source)
	  {
	  	Console.WriteLine(text + " " + item);
		yield return item;
	  }
	}

}
// You can define other methods, fields, classes and namespaces here