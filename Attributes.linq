<Query Kind="Program">
  <RuntimeVersion>3.1</RuntimeVersion>
</Query>

void Main()
{
	foreach(MethodInfo mi in typeof(Foo).GetMethods())
	{
		TestAttribute att = (TestAttribute)Attribute.GetCustomAttribute(mi, typeof(TestAttribute));
		
		if(att != null)
		{
			Console.WriteLine($"Method {mi.Name} will be tested; reps={att.Repetitions}; msg={att.FailureMessage}");
		}
	}
}

[AttributeUsage(AttributeTargets.Method)]
public sealed class TestAttribute : Attribute
{
	public int Repetitions;
	public string FailureMessage;
	
	public TestAttribute() : this(1){}
	public TestAttribute(int repetitions)
	{
		Repetitions = repetitions;
	}
}

class Foo
{
	[Test]
	public void Method1(){}
	
	[Test(20)]
	public void Method2(){}
	
	[Test(20, FailureMessage="Debugging time")]
	public void Method3(){}
}

// Define other methods and classes here
