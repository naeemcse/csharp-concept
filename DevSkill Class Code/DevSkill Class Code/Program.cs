using System.Reflection;


Assembly a = Assembly.GetExecutingAssembly();
var types = a.GetTypes();

foreach(Type t in types)
{
   var interfaces = t.GetInterfaces();
    if (interfaces.Any(x => x.Name == "IPurchasable"))
    {

        ConstructorInfo? constructor = t?.GetConstructor([typeof(string), typeof(double), typeof(double)]);
        object? o = constructor?.Invoke(["Camera",3000,10]);

        MethodInfo? method1 = t?.GetMethod("CalculatePriceAfterTax",BindingFlags.Instance | BindingFlags.Public);
        MethodInfo? method2 = t?.GetMethod("CalculateDiscount", BindingFlags.Instance | BindingFlags.Public);


        double? r1 = (double?)method1.Invoke(o, []) ;
        double? r2 = (double?)method2.Invoke(o, [5]) ;

        Console.WriteLine(r1);
        Console.WriteLine(r2);

    }




}

 