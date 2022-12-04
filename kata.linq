<Query Kind="Program" />

void Main()
{
	Console.WriteLine(NextSmaller(570167));
}

public static long NextSmaller(long n)
{
	List<int> original = Array.ConvertAll(n.ToString().ToArray(), x => (int)x - 48).ToList();
	var numberGroups = original
            .GroupBy(num => num)
            .Select(num => new
            {
                Key = num.Key,
                Value = num.Count()
            }
            ).OrderBy(num => num.Key);
    
	Dictionary<int, int> origDic = new Dictionary<int, int>();
	
    foreach (var grp in numberGroups) 
	{
        Console.WriteLine("{0} - {1}", grp.Key, grp.Value);
		origDic.Add(grp.Key, grp.Value);
	}
	
	while(true)
	{
		n--;
		List<int> temp = Array.ConvertAll(n.ToString().ToArray(), x => (int)x - 48).ToList();
		if(temp.Count < original.Count)
			break;
		var tempGroups = temp
            .GroupBy(num => num)
            .Select(num => new
            {
                Key = num.Key,
                Value = num.Count()
            }
            ).OrderBy(num => num.Key);
		Dictionary<int, int> tempDic = new Dictionary<int, int>();
	    foreach (var grp in tempGroups) 
		{
	        //Console.WriteLine("{0} - {1}", grp.Key, grp.Value);
			tempDic.Add(grp.Key, grp.Value);
		}	
		
		if(tempDic.Count() != origDic.Count())
			continue;
		if (Enumerable.SequenceEqual(origDic, tempDic))
		{
			Console.WriteLine("Совпали");
			return n;
		}
	}
	return -1;
}

public static long NextSmallerBest(long n)
{
	var a = n.ToString();
    var bigger = Enumerable.Range(1, a.Length - 1)
      .LastOrDefault(i => a[i-1] > a[i]) - 1;
    if (bigger < 0)
      return -1;
    var smaller = Enumerable.Range(bigger+1, a.Length - bigger - 1)
      .Where(i => a[bigger] > a[i])
      .Aggregate((acc,next) => a[acc] > a[next] ? acc : next);
    if (bigger == 0 && a[smaller] == '0')
      return -1;
    var sb = new StringBuilder(a);
    char temp = sb[bigger]; sb[bigger] = sb[smaller]; sb[smaller] = temp;
    a = sb.ToString();
    return long.Parse(
      a.Substring(bigger+1)
        .OrderByDescending(c => c)
        .Aggregate(new StringBuilder(a.Substring(0, bigger + 1)),
          (acc,ch) => acc.Append(ch))
        .ToString());
}

// Define other methods and classes here