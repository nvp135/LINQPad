<Query Kind="Program" />

void Main()
{
	Helper.Report("Start the programm");
	new MC2().Method();
}

// Define other methods and classes here

public class MC
{
	public int fieldWithDefaultValue = 5;
	public int publicField;
	public readonly int publicReadonlyField;
	static public int staticPublicField;
	static public readonly int staticPublicReadonlyField;
	
	public MC(int c)
	{
		publicField = c;
		publicReadonlyField = c;
		staticPublicField = c;
		
		//нельзя
		//staticPublicReadonlyField = 1;
	}
	
	public MC() :this(2)
	{	}
	
	static MC()
	{
		staticPublicField = 1;
		staticPublicReadonlyField = 1;
	}
}

class Helper
{
	public static int Report(string str)
	{
		Console.WriteLine(str);
		return 0;
	}

}

class MC2
{
	static int staticField = Helper.Report("Initialization static fields");
	
	static MC2()
	{
		Helper.Report("Static constructor");
	}
	
	int field = Helper.Report("Initialization non-static fields");
	
	public MC2(int c)
	{
		Helper.Report("Constructor called another construcor");
	}
	
	public MC2() : this(1)
	{
		Helper.Report("Called constructor");
	}
	
	public void Method()
	{
		Helper.Report("Method");
	}
}