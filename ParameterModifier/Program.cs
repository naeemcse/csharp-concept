
using ParameterModifier;

// Example of Params 
double[] arr =
{
    10, 11, 12, 13, 14.5, 15, 16.5,
};

Geometry geometry = new Geometry();

double ans = geometry.CalculateAverage(arr);
Console.WriteLine(ans);

Console.WriteLine("Another ans:"+ geometry.CalculateAverage(5,10,15));
// using ref
int m = 5;
geometry.PrintAndChange(ref m);
Console.WriteLine(m);

// using in // 
geometry.Calculate(in m);

// using out 
int x,y,z;
geometry.MultiReturn( out x, out y);

Console.WriteLine($"x:{x} y: {y}");

