<Query Kind="Program" />

void Main()
{
	var graph = new Dictionary<string, Node>();
	var n = new Node("start");
	
	graph.Add(n.Value, n);
}

class Node 
{
	public Node(string value) 
	{
		this.Value = value;
	}
	
	public string Value {get; }
	
	//Node parent;
	
	List<Node> childrens = new List<Node>();
	
}

// You can define other methods, fields, classes and namespaces here