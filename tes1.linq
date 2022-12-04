<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

int[] src = new [] { 6, 1, 2, 5, 3, 3, 2, 6, 6, };
var result = src.ToList().GroupBy(c => c).Select(f => f.First()).ToArray();
for(int i = 0; i < result.Length; i++)
Console.WriteLine(result[i]);
