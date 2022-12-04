<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var rnd = new Random();
	List<int> targetList = new List<int>();
	for(int i = 0; i < 1000; i++)
	{
		targetList.Add(rnd.Next(0,100000));
	}
	
	PrintList(targetList);
	PrintList(BubbleSort(new List<int>(targetList)));
	PrintList(targetList);
	PrintList(SelectionSort(new List<int>(targetList)));
}

IList BubbleSort(List<int> list)
{
	Stopwatch sw = new Stopwatch();
	sw.Start();
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
	sw.Stop();
	Console.WriteLine($"Swop count: {swopCount}");
	Console.WriteLine($"Bubble Sort: {sw.Elapsed}");
	return list;
}

IList SelectionSort(List<int> list)
{
	Stopwatch sw = new Stopwatch();
	sw.Start();
	int swopCount = 0;
	for(int i = 0; i < list.Count; i++)
	{
		var lowestNumberIndex = i;
		for(int j = i + 1; j < list.Count; j++)
		{
			if(list[j] < list[lowestNumberIndex])
			{
				lowestNumberIndex = j;
			}
		}
		if(lowestNumberIndex != i) 
		{
			var temp = list[i];
			list[i] = list[lowestNumberIndex];
			list[lowestNumberIndex] = temp;
			swopCount++;
		}
	}
	sw.Stop();
	Console.WriteLine($"Swop count: {swopCount}");
	Console.WriteLine($"Selection Sort: {sw.Elapsed}");
	return list;
}

void PrintList(IList list)
{
	foreach(int v in list)
	{
		Console.Write($"{v} ");
	}
	Console.WriteLine();
}