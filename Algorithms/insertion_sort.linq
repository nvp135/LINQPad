<Query Kind="Program" />

void Main()
{
	//var array = new int[8]{7, 6, 5, 4, 3, 2, 1, 0};
	var array = new int[8]{0, 1, 2, 3, 4, 5, 6, 7};
	Array.ForEach(array, a => Console.Write($"{a} "));
	Console.WriteLine();
	insertion_sort(array);
	Array.ForEach(array, a => Console.Write($"{a} "));
	
}

void insertion_sort(int[] A)
{
	int op_count = 0;
	for(int j = 1; j < A.Length; j++)
	{
		op_count++;
		int key = A[j];
		int i = j - 1;
		while(i >= 0 && A[i] > key)
		{
			A[i+1] = A[i];
			i--;
			op_count++;
		}
		A[i +1] = key;
		Array.ForEach(A, a => Console.Write($"{a} "));
		Console.WriteLine();
	}
	Console.WriteLine(op_count);
}


// Define other methods, classes and namespaces here
