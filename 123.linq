<Query Kind="Program" />

void Main()
{
	/*int[] values = new int[]{ 1,2,3,4,5,6,7,8,9,10};
	var ints = Enumerable.Range(0, 1000).Where(s => (s % 3 == 0) && (s % 5 != 0));
	foreach(var i in ints)
	{
		if (i.ToString().ToCharArray().Select(Char.GetNumericValue).Aggregate((x, y) => x + y) < 10)
			Console.WriteLine(i);
	}*/
	
	Pet p = new Cat();
	Shape s = new Ball();
	Cat c = new Cat();
	Console.WriteLine(c.getName());
	
	var car = new Car(200, "Manual");
	Console.WriteLine(Veh.country);
}

public class Veh
{
	public int maxSpeed;
	
	public static string country;
	
	public Veh(int ms)
	{
		this.maxSpeed= ms;
		country = "Ru";
	}
}

public class Car : Veh
{
	public string trans;
	public Car(int maxsp, string trans) : base(maxsp)
	{
		this.maxSpeed = 100;
		this.trans = trans;
	}

	static Car()
	{
		country = "USA";
	}
}

public class Shape
{public string getName(){return "shape";}}

public class Ball: Shape
{public new string getName(){return "ball";}}

public class Pet
{public virtual string getName(){return "pet";}}

public class Cat : Pet
{public override string getName(){return "cat";}}
// Define other methods and classes here
