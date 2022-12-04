<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

//using System.Collections.Generic;

void Main()
{
	var rnd = new Random();
	List<int> targetList = new List<int>();
	for(int i = 0; i < 55; i++)
	{
		targetList.Add(rnd.Next(0,10));
	}
	foreach(int v in targetList)
	{
		Console.Write($"{v} ");
	}
	
	Console.WriteLine();
	
	BubbleSort(targetList);
	
	foreach(int v in targetList)
	{
		Console.Write($"{v} ");
	}
}

void BubbleSort(List<int> list)
{
	//int i = list.Count()-1;
	int swopCount = 0;
	for(int i = list.Count()-1; i > 0; i--)
	{
		for(int j = 0; j < i; j++)
		{
			if(list[j] > list[j+1])
			{
				var t = list[j];
				list[j] = list[j+1];
				list[j+1] = t;
				swopCount++;
			}
		}
		//i--;
	}
	Console.WriteLine(swopCount);
}

// Define other methods and classes here