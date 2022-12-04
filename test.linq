<Query Kind="Program" />

void Main()
{
	/*var v1 = new getvalue(value1);
	var v2 = new getvalue(value2);
	var chain = v1;
	chain += v2;
	Console.WriteLine(chain());
	int a = -5;
	Console.WriteLine(~a);
	Console.WriteLine("{0:x8}, {1:x8}", -5, ~(-5));
	Console.WriteLine("{0:x8}, {1:x8}", -2, ~(0));*/
	sbyte i = 0;
	for(int x=0; x < 200 ; i++, x++)
	{
		Console.WriteLine("{0:d} - {0:x4}, {1:x4}", i, i, ~(i));
	}
}


delegate int getvalue();

int value1() { return 1; }
int value2() { return 2; }
// Define other methods, classes and namespaces here
