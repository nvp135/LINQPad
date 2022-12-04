<Query Kind="Program" />

void Main()
{
	var sort = new InsertionSort();
	var context = new Context(sort);
	context.Sort();
	context.PrintArray();
}

class Context
{
	Strategy strategy;
	int[] array = {10, 4, 1, 3, 6, 1, 0, 15};
	
	public Context(Strategy strategy)
	{
		this.strategy = strategy;
	}
	
	public void Sort()
	{
		strategy.Sort(ref array);
	}
	
	public void PrintArray()
	{
		Console.WriteLine();
		foreach(var i in array)
			Console.Write($"{i} ");
		Console.WriteLine();
	}
}

abstract class Strategy
{
	public abstract void Sort(ref int[] array);
}

class InsertionSort : Strategy
{
	public override void Sort(ref int[] array)
	{
		Console.WriteLine("Insertion Sort");
		
		for(int i = 1; i < array.Length; i++)
		{
			int j = 0;
			int buffer = array[i];
			
			for(j = i - 1; j >= 0; j--)
			{
				if(array[j] < buffer)
				{
					break;
				}
				array[j+1] = array[j];
			}
			
			array[j+1] = buffer;
		}
	}
}

class BubbleSort : Strategy 
{
	public override void Sort(ref int[] array)
	{
		Console.WriteLine("BubbleSort");
		
		for(int i = 0; i < array.Length; i++)
		{
			for(int j = array.Length -1; j > i; j--)
			{
				if(array[j] < array[j-1])
				{
					int temp = array[j];
					array[j] = array[j - 1];
					array[j-1] = temp;
				}
			}
		}
	}
}

class SelectionSort : Strategy
{
	public override void Sort(ref int[] array)
	{
		Console.WriteLine("SelectionSort");
		
		for(int i = 0; i < array.Length - 1; i++)
		{
			int k = i;
			
			for(int j = i + 1; j < array.Length; j++)
			{
				if(array[k] > array[j])
					k = j;
			}
			
			if(k != i)
			{
				int temp = array[k];
				array[k] = array[i];
				array[i] = temp;
			}
		}
	}
}

// You can define other methods, fields, classes and namespaces here
