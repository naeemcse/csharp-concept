using System;
interface Addition
{
   int add();
}
interface Multiplication
{
    int Mul();
}

class Computation : Addition, Multiplication
{
    int x, y;

    public Computation(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int add()
    {
       return x + y;
         
    }
 
    public int Mul()
    {
        return x * y;
         
    }
}

class InterfaceTest1
{
    public static void Main(String[] args)
    {
        Computation com = new Computation(1, 2);
        Console.WriteLine(com.add());
    }
}