<Query Kind="Program" />


void Main()
{
	HashSet<int> evenNumbers = new HashSet<int>();
	HashSet<int> oddNumbers = new HashSet<int>();
	
	for(int i = 0; i < 25; i++)
	{
		evenNumbers.Add(i * 2);
		oddNumbers.Add((i * 2) + 3);
	}
	
	Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
	DisplaySet(evenNumbers);
	Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
	DisplaySet(oddNumbers);
	
	HashSet<int> numbers = new HashSet<int>(evenNumbers);
	Console.WriteLine("numbers UnionWith oddNumbers");
	numbers.UnionWith(oddNumbers);
	Console.Write("numbers contains {0} elements: ", numbers.Count);
	DisplaySet(numbers);
}

void DisplaySet(HashSet<int> collection)
{
	Console.Write("{");
	foreach(int i in collection)
	{
		Console.Write(" {0}", i);
	}
	Console.WriteLine(" }");
	
}
// Define other methods, classes and namespaces here
