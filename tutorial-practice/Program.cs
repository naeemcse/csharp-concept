using System;

class WaterBottle
{
    private double capacity;
    public string color;
    private double waterAmount ;
    // একখানে waterAmount প্রাইভেট তাই বাহির থেকে এটাকে এক্সেস করা যাবে না 

    // কিন্তু আমরা চাইলেই WaterWaterAmount কে কল করবো সামনে থেকে , সে আসলে ভিতরে ভিতরে private double waterAmount ; এর মানকে ব্যবহার করবে । 
    public WaterBottle(double a,string r)
    {
        capacity = a;
        color = r;
    }

    public double WaterWaterAmount
    {
        get
        {
            return waterAmount;
        }
        set
        {
            waterAmount = value;
        }
    }

    public void addWater(int amount)
    {
        waterAmount += amount;
    }
    public void ReleaseWater(int amount)
    {
        waterAmount -= amount;
    }

}

// Main Function

namespace CsharpApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            WaterBottle bottle1 = new WaterBottle(100,"Red");
            bottle1.addWater(100);
            Console.WriteLine(bottle1.color);
        

          
        }
    }
}