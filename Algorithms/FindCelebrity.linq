<Query Kind="Program" />

void Main()
{
	var p1 = new Person("Nik", null);
	var p2 = new Person("Jan", null);
	var p3 = new Person("Set", null);
	var p4 = new Person("Gor", null);
	var p5 = new Person("Mob", null);
	var p6 = new Person("Kim", null);
	
	p1.knownPersons.AddRange(new List<Person> {p2, p5, p6});
	p2.knownPersons.AddRange(new List<Person> {p1, p6});
	p3.knownPersons.AddRange(new List<Person> {p2, p6});
	p4.knownPersons.AddRange(new List<Person> {p3, p6});
	p5.knownPersons.AddRange(new List<Person> {p1, p2, p6});
	
	
	FindCelebrity(new List<Person>{p1, p2, p3, p4, p5, p6});
}

Person FindCelebrity(List<Person> persons)
{
	int r = 0, l = persons.Count() - 1;
	
	while(r != l)
	{
		if(persons[r].knownPersons.Contains(persons[l]))
			r++;
		else 
			l--;
	}
	
	//r.Dump("r"); l.Dump("l");
	
	Console.WriteLine(persons[r]);
	
	return null;
}

class Person
{
	public string Name { get; private set; }
	
	public List<Person> knownPersons = new List<Person>();
	
	public Person(string name, List<Person> knownPersons)
	{
		this.Name = name;
		if(knownPersons != null) this.knownPersons = knownPersons;
	}
	
	public override string ToString()
	{
		return this.Name;
	}
}

// You can define other methods, fields, classes and namespaces here
