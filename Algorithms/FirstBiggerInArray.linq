<Query Kind="Program" />

using System.Collections.Generic;

void Main()
{
	var arr = new int[10] {14, 4, 13, 15, 11, 5, 9, 8, 18, 7};
	FindFirstBigger(arr);
	
	FindFirstBiggerStack(arr);
	FindFirstBiggerStackBetter(arr);
}

int[] FindFirstBigger(int[] arr)
{
	var res = new int[arr.Count()];
	
	for(int i = 0; i < arr.Count()-1; i++)
	{
		for(int j = i + 1; j < arr.Count()-1; j++)
		{
			if(arr[j] > arr[i]) 
			{
				res[i] = j - i;
				break;
			}
		}
	}
		
	res.Dump();
	return res;
}

int[] FindFirstBiggerStack(int[] arr)
{
	var result = new int[arr.Count()];
	
	var stack = new Stack<(int, int)>();
	
	for(int i = arr.Count() - 1; i >= 0; i--)
	{
		while(stack.Count() > 0)
		{
			var val = stack.Peek();
			if(val.Item1 > arr[i])
			{
				result[i] = val.Item2 - i;
				stack.Push((arr[i], i));
				break;
			}
			else
			{
				stack.Pop();
			}
		}
		
		if(stack.Count() == 0)
		{
			stack.Push((arr[i], i));
			result[i] = 0;
			continue;
		}	
	}
	
	result.Dump();
	
	return result;
}

int[] FindFirstBiggerStackBetter(int[] arr)
{
	var result = new int[arr.Count()];
	
	var stack = new Stack<(int, int)>();
	
	for(int i = arr.Count() - 1; i >= 0; i--)
	{
		while(stack.Count() > 0 && stack.Peek().Item1 <= arr[i])
		{
			stack.Pop();
		}
		
		if(stack.Count() != 0)
		{
			result[i] = stack.Peek().Item2 - i;
			stack.Push((arr[i], i));
		}
		stack.Push((arr[i], i));
	}
	
	result.Dump();
	
	return result;
}