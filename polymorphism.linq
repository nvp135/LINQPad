<Query Kind="Program" />

void Main()
{
	var b = new B();
	
	var a = (A)b;
	
	a.Run1();
	a.Run2();
	
}

class A
{
	public virtual void Run1()
	{
		Console.WriteLine("Run1 A");
	}
	
	public virtual void Run2()
	{
		Console.WriteLine("Run2 A");
	}
}

class B : A 
{
	public override void Run1()
	{
		Console.WriteLine("Run1 B");
	}
	
	public new void Run2()
	{
		Console.WriteLine("Run2 B");
	}
}

// You can define other methods, fields, classes and namespaces here
