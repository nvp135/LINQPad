<Query Kind="Program" />

void Main()
{
	CalculatePathsExponent(2, 3).Dump();
	
	CalculatePaths(2, 3).Dump();
}

int CalculatePathsExponent(int n, int m) // O(2^(n+m)) - exponent
{
	if(n < 1 || m < 1) return 0;
	
	if(n == 1 && m == 1) return 1;
	
	return CalculatePathsExponent(n-1, m) + CalculatePathsExponent(n, m-1);
}

int CalculatePaths(int n, int m) // O(n*m)
{
	return CalculatePathChache(n, m, new int[n, m]);
}

int CalculatePathChache(int n, int m, int[,] arr)
{
	if(n < 1 || m < 1) return 0;
	
	if(n == 1 && m == 1) return 1;
	
	if(arr[n - 1, m - 1] != 0) return arr[n - 1, m - 1];
	
	arr[n - 1, m - 1] = CalculatePathChache(n - 1, m, arr) + CalculatePathChache(n, m - 1, arr);
	
	return arr[n - 1, m - 1];
}
