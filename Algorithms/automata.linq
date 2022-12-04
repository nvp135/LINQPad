<Query Kind="Program" />

using System.Collections.Generic;

int ROWS_COUNT = 3_0;
int ROW_LENGTH = 3_0;

void Main()
{	
	var currentState = new int[ROW_LENGTH];
	var nextState = new int[ROW_LENGTH];
	
	var rule = GetRule(110);
	
	currentState[0] = 1;
	
	for(int r = 0; r < ROWS_COUNT; r++)
	{
		foreach(var l in currentState)
		{
			Console.Write(l);
		}
		
		for(int i = 0; i < ROW_LENGTH; i++)
		{
			nextState[i] = rule[$"{currentState[TorIt(i-1)]}{currentState[TorIt(i)]}{currentState[TorIt(i+1)]}"];
		}
		for(int i = 0; i < ROW_LENGTH; i++)
		{
			currentState[i]=nextState[i];
		}
		Console.WriteLine();
		
		Thread.Sleep(100);
	}
}

Dictionary<string, int> GetRule(int ruleNum)
{
	var result = new Dictionary<string, int>();
	
	var rule = new string(Convert.ToString(ruleNum, 2).PadLeft(8, '0').Reverse().ToArray());
	
	for(int i = 0; i < 8; i++)
	{
		result.Add(Convert.ToString(i, 2).PadLeft(3, '0'), Convert.ToInt32(rule[i].ToString()));
	}
	
	return result;
}

int f(int y1, int y2, int y3)
{
	return y1 ^ y2 | y3;
}

int TorIt(int x)
{
	if(x < 0)
	{
		return x + ROW_LENGTH;
	}
	else
	{
		return x % ROW_LENGTH;
	}
}
// You can define other methods, fields, classes and namespaces here
