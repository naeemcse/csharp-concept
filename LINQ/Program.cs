
using LINQ;
using System.Linq;

public class Program
    {
        private static void Main(string[] args)
        {

        //ShowWord();
        //ShowNumber();
        //  SorNumber(new List<int> { 1,3,2,10,5});
        ComplexSort();



        }

        static void  ShowNumber()
        {
            List<int> num = new List<int>() { 1, 2, 3, 4, 5 };

            foreach (int i in num)
                Console.Write(i + " ");
            Console.WriteLine();

            // Where 
            var evenNumbers = num.Where(n => n % 2 == 0);

            foreach (int i in evenNumbers)
                Console.Write(i + " ");
        }
        public static void ShowWord()
        {
            List<string> words = new List<string>() { "Apple", "Banana", "Mango", "Orange", "Ang", "Pin" };
            var filteredword = words.Where(word => word.Length <= 3);

            foreach (string word in filteredword)
                Console.Write(word + " ");


        }

    // Linq Query: 
     static void SorNumber(List<int> list)
    {
        var nums = list.OrderBy(n => n) ;

        foreach (int i in nums)
            Console.Write($"{i} , ");
    }

    static void ComplexSort()
    {
        List<Person> people = new List<Person>()
        {
            new Person("Najmul Islam Naeem",24,30000),
            new Person("Khadija Husen Juthi", 24 ,20000),
            new Person("Sahjahan",24,40000)
        };
       var selectedPeople = people.OrderByDescending(n => n.Age) ;
        foreach(Person person in selectedPeople)
            Console.WriteLine(person.Name + " " + person.Age);
        var doubleSorted = people.OrderBy(n => n.Age).ThenBy(people=>people.Name);
        Console.WriteLine("Double sorted on age and Name.");
        foreach (Person person in doubleSorted )
            Console.WriteLine(person.Name + " " + person.Age);


        // All() is used for satisfying every element 
        // Any() is used for anyone element satisfying condition

        bool allAudult = people.All(p => p.Age >= 20);
        bool AnyAudult = people.Any(p => p.Age < 18);

        // contains  return bool , is there any match of string

        bool containsNaeem = people.Select(p => p.Name).Contains("Naeem");


    }

    // Aggrigation: Sum,Max,Min,Average,Count
    static void Aggrigration()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6 };

        int sum = nums.Sum();
        double avr = nums.Average();
        int mx = nums.Max();
        int my = nums.Min();
        int cnt = nums.Count();


    }

    // Skip(n)/Take(n)/First()/
    // From item in listName where Condition Select item


}
