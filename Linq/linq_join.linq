<Query Kind="Statements" />

var customers = new[] {
	new {ID = 1, Name = "Вася" },
	new {ID = 2, Name = "Петя" },
	new {ID = 3, Name = "Елена" },
};

var purchases = new[] {
	new {CustomerId = 1, Product = "Дверь"},
	new {CustomerId = 2, Product = "Корова"},
	new {CustomerId = 2, Product = "Кинескоп"},
	new {CustomerId = 3, Product = "Палка"},
	new {CustomerId = 3, Product = "Очки"},
};

var query = 
	from c in customers
	join p in purchases on c.ID equals p.CustomerId
	select c.Name + " bought " + p.Product;

var query1 = customers.Join(purchases,
	c => c.ID,
	p => p.CustomerId,
	(c, p) => c.Name + " bought " + p.Product);
	
foreach(string s in query)
	Console.WriteLine(s);

Console.WriteLine("*****");

foreach(string s in query1)
	Console.WriteLine(s);
