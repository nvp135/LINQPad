<Query Kind="Program" />

void Main()
{
	//int x = int.MaxValue;
	//Console.WriteLine(x + 1);
	//Console.WriteLine(1000000000 >> 27);
	//Console.WriteLine(1000000000 << 5);
	Console.WriteLine((0b110 >> 1) | (0b1 << 3));
	Console.WriteLine(2|4);
	
	Console.WriteLine(Combine(1, 1));
	//Console.WriteLine(checked(x + 10));
}

public static int Combine(int h1, int h2)
{
	uint rol5 = ((uint)h1 << 5) | ((uint)h1 >> 27);
	return ((int)rol5 + h1) ^ h2; 
}

// You can define other methods, fields, classes and namespaces here
