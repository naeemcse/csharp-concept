object o = new { Name = "Naeem", age = 23 };

dynamic p = o;

Console.WriteLine(p.Name);