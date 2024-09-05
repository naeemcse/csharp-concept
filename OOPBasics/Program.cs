
using OOPBasics;
using System.Runtime.InteropServices;

WaterBottle bottle1 = new WaterBottle();
while (true)
{
    Console.Write("Please Initialize water capacity of your bottle:");
    double input = double.Parse(Console.ReadLine());
    if (input <= 0)
    {
        Console.WriteLine("\nPlease Enter Positive Number.\n");
       
    }
    else
    {
        bottle1.Capacity = input;
        break;
    }
}

Console.Write("Write your bottle color:");
string colorName = Console.ReadLine();

bottle1.Color = colorName;

while (true)
{
    Console.Write("\n\nPlese Select Operation: \n 1 to adding water \n 2 to realese water \n 3 to Show current Amount.\n 4 to show available space .\n 5 to show details of bottle \n 6 to Close program.\n\n");

    int comand = int.Parse(Console.ReadLine());
    if (comand == 1)
    {
        Console.Write("Please Enter Positive Number to add :");
        double water = double.Parse(Console.ReadLine());
        if (water <= 0)
        {
            Console.Write("Please Enter Positive Number to add .");
           
        } else if (water > bottle1.Capacity)
        {
            Console.WriteLine($"You canot add more than your capacity and space.You can only add {bottle1.Capacity - bottle1.waterAmount} Litter water.");
        }
        else
        {
            bottle1.AddWater(water);
            Console.WriteLine($"{water} Liter is added. Your Current water level is : {bottle1.waterAmount}");
        }
    }
    else if (comand == 2)
    {

        Console.Write("Please Enter Positive Number to realise :");
        double water = double.Parse(Console.ReadLine());
        if (water <= 0)
        {
            Console.Write("Please Enter Positive Number. \n ");
           
        }
        else if(water <= bottle1.waterAmount)
        {
            bottle1.ReleaseWater(water);
            Console.WriteLine($"{water} Liter is realised. Your Current water level is : {bottle1.waterAmount}");
        } else
        {
            Console.WriteLine($"{water} Liter can not realise. Because Your Current water level is : {bottle1.waterAmount} You can only add {bottle1.Capacity - bottle1.waterAmount} Litter water  ! ");
        }
    }
    else if (comand == 3)
    {

        Console.WriteLine($"Your Current water level is : {bottle1.waterAmount}");
    }
    else if (comand == 4)
    {
        Console.WriteLine($"You can only add {bottle1.Capacity - bottle1.waterAmount} Litter water  ! ");
            }
    else if (comand == 5)
    {
        Console.WriteLine($"\n\nYour bottle color is:{bottle1.Color}.\nTotal Capacity is: {bottle1.Capacity}.\nYour Current water level is : {bottle1.waterAmount}.\nYou can only add {bottle1.Capacity - bottle1.waterAmount} Litter water!");
    }
    else if (comand == 6)
        break;
    else Console.WriteLine("Write a valid command serial.");
}