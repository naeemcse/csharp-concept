
// without variable name
(int, string) x = (5, "Hello");
Console.WriteLine(x.Item1);
Console.WriteLine(x.Item2);

// with variable name 

(int age, string name) person;
person.age=10; person.name = "Naeem";
Console.WriteLine(person.age);
Console.WriteLine(person.name);


// function 
(int, double) Calculate(int[] items)
{
    int sum = 0;
    foreach (var item in items)
    {
        sum += item;
    }
    double avr = sum/items.Length;

    return (sum, avr);
}
int[] arr = { 10, 100, 200 };
Console.WriteLine(Calculate(arr));

// Array of touple 

(int, string)[] personsInfo = [(23, "Naeem"), (32, "Najmul")];