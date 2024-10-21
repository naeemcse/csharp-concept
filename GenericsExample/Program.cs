
using GenericsExample;

Coordinate<int> c = new Coordinate<int>();
c.X=19; c.Y = 1;
int x = c.X; 

Coordinate2<int,double> cc = new Coordinate2<int,double>();
cc.A = 1; cc.B=2.22;

//Console.WriteLine(cc.A);

// Shorting 
BubbleShort<int> num = new BubbleShort<int>();
var result = num.Sort(new int[] { 10, 19, 2 });

print(result);

BubbleShort<double> b = new BubbleShort<double>();
var ans = b.Sort(new double[] { 10.5, 19.2, 2.02 });
print(ans);



void print<T>(T[] result)
{
    foreach (var item in result)
        Console.WriteLine(item);
}