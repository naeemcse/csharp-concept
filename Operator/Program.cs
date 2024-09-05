
// Bitwise operator 
int a = 10; // 101
int b = a << 1; // 1010
int c = a >> 1; // 010
Console.WriteLine(Convert.ToString(a,toBase:2));
Console.WriteLine(Convert.ToString(b,toBase:2));
Console.WriteLine(Convert.ToString(c,toBase:2));



// Exmaple with Binary 
int bin = 0b1010_1011;
Console.WriteLine(Convert.ToString(bin,toBase:2));
int bin1 = bin >> 2;
Console.WriteLine(Convert.ToString(bin1,toBase:2));
int bin2 = bin << 2;
Console.WriteLine(Convert.ToString(bin2,toBase:2));