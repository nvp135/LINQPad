<Query Kind="Program" />

void Main()
{
	Point p = new Point(1, 1);
	Console.WriteLine(p);
	
	p.Change(2, 2);
	Console.WriteLine(p);
	
	Object o = p;
	Console.WriteLine(o);
	
	((Point)o).Change(4, 4);
	Console.WriteLine(o);
	
	((IChangedBoxedPoint)p).Change(4, 4); // Вызов метода на объекте с его запаковкой. p остается в стэке, а вызов функции на анонимном объекте а куче.
	Console.WriteLine(p);
	
	((IChangedBoxedPoint)o).Change(5, 5); // Вызов метода на запакованом объекте. Значение меняется
	Console.WriteLine(o);	
}

interface IChangedBoxedPoint
{
	void Change(Int32 x, Int32 y);
}

internal struct Point : IChangedBoxedPoint
{
	private Int32 m_x, m_y;
	
	public Point(Int32 x, Int32 y)
	{
		m_x = x;
		m_y = y;
	}
	
	public void Change(Int32 x, Int32 y)
	{
		m_x = x;
		m_y = y;		
	}
	
	public override string ToString() 
	{
		return String.Format("({0}, {1})", m_x.ToString(), m_y.ToString());
	}
}