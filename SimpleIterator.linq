<Query Kind="Program" />

void Main()
{
	foreach(int value in CreateSimpleIterator())
	{
		Console.WriteLine(value);
	}
}

static IEnumerable<int> CreateSimpleIterator()
{
	yield return 10;
	for(int i = 0; i < 13; i++)
	{
		yield return i;
	}
	yield return 20;
}

// You can define other methods, fields, classes and namespaces here
