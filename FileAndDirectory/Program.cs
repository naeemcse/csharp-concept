// file : video of class 18



// Directory
// Creat
// Directory.CreateDirectory("Videos/Training");

// Current path
string crntPath = Directory.GetCurrentDirectory();
Console.WriteLine(crntPath);

// concatinatio of path

Directory.SetCurrentDirectory(Path.Combine(crntPath,"Videos/Training"));
File.WriteAllText("sample.txt", "HEllow Bangladesh");










