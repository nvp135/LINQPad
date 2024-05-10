<Query Kind="Program" />

void Main()
{
	Console.WriteLine(GetItemByIndex(new int[] {0,1,2,3,4,5,6,7,8,9}, 105));
}


int GetItemByIndex(int[] array, int index) 
{
	return array[index % array.Length];
}
// You can define other methods, fields, classes and namespaces here