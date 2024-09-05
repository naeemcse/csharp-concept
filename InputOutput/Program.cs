// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("just write"); 
Console.Write("just write 2 "); 


// Readline 

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is : " + n);



// String' to number ; 

string line = Console.ReadLine();

string[] lineParts = line.Split(' ', ',');

for(int i = 0; i < lineParts.Length; i++)
{
    lineParts[i] = lineParts[i].Trim();
}

int[] numers = new int[lineParts.Length];
int counter = 0;
foreach (string num in lineParts)
{
    numers[counter++] = Convert.ToInt32(num);
}

for (int i = 0;i < numers.Length; i++)
    Console.WriteLine(numers[i]);

