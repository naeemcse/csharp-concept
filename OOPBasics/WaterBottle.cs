using System;

namespace OOPBasics
{
    internal class WaterBottle
    {
        private double capacity = 0 ;
        public string color;
        public double waterAmount;

         // Property 
         public double Capacity
        {
            set
            {if (value <= 0) return;
                capacity = value;
            }
            get
            {
                return capacity;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }

        }
        public void AddWater(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Sorry Invalid Input ! Input will be greater than 1");
            }
            else if(amount < capacity)
            waterAmount += amount;
            else
            {
                Console.WriteLine($"Your Bottal's Capacity is: {capacity} ! but you are adding excess. ");
            }
        }
        public void ReleaseWater(double amount) { 
            if (amount <= 0)
            {
                Console.WriteLine("Sorry Invalid Input ! Input will be greater than 1");
            } else if(amount> waterAmount)
            {
                Console.WriteLine($"Amount is higer than Water amount. Your current Amount is : {waterAmount}"); 
            }
        else 
            waterAmount -= amount;

        }

    }
}
