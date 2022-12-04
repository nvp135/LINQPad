<Query Kind="Program" />

void Main()
{
	var ec = new EventKeywordDemo();
	ec.Test();
}

// You can define other methods, fields, classes and namespaces here

public class EventKeywordDemo
{
    public event Action<int, bool> event1;

    public Action<int, bool> action1;

    public event EventHandler event2;

    public delegate void SampleEventType(int param1, bool param2); //Equivalent to Action<int, bool>
    public event SampleEventType event3;

    public void Test()
    {
        //+= calls Delegate.Combine
        //-= calls Delegate.Remove

        event1 += OtherClass.Function1;
        event1 += OtherClass.Function2;

        action1 += OtherClass.Function1;
        action1 += OtherClass.Function2;

        event2 += EventHandlerFunctionExample;

        event3 += OtherClass.Function1;

        event1?.Invoke(3, true);
        action1?.Invoke(3, true);

        event1 = null;
        action1 = null;
    }

    private void EventHandlerFunctionExample(object sender, EventArgs e)
    {
        
    }
}

public class OtherClass
{
    public void Test()
    {
        EventKeywordDemo ekd = new EventKeywordDemo();

        ekd.event1 += Function1;
        ekd.event1 += Function2;
        ekd.action1 += Function1;
        ekd.action1 += Function2;

        //ekd.event1?.Invoke(3, true); //Doesn't Compile
        ekd.action1?.Invoke(3, true);

        //ekd.event1 = null; //Doesn't Compile
        ekd.action1 = null;
    }

    public static void Function1(int param1, bool param2)
    {
		Console.WriteLine($"{param1} {param2}");
    }

    public static void Function2(int param1, bool param2)
    {
		Console.WriteLine($"{param1} {param2}");
    }
}