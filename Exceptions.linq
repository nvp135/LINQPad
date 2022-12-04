<Query Kind="Program" />

void Main()
{
	try 
    {
		try 
		{
			throw new ArgumentException("Argument is null");	
		}
        catch
		{
			throw;
		}
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine("OK");
    }
}

// You can define other methods, fields, classes and namespaces here
