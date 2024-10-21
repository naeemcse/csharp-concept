using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    internal class Geometry
    {
        // Example of Params 

        public double CalculateAverage(params double[] items)
        {
            double sum = 0;
            foreach (var item in items)
            {
                sum += item;
            }
            return sum/items.Length;
        }

        // using Ref
        public void PrintAndChange(ref int x )
        {
            Console.WriteLine("x:"+x);
            x = 10;
        }
        // using in 
        public void Calculate(in int  x)
        {
            Console.WriteLine(x);
            // বাহিরে রিটার্ন করা যাবে না । 
        }
        // using out 
        // out ব্যবহার করে একাধিক ডাটা রিটার্ন করা যায় । 

        public void MultiReturn(out int x, out int y)
        {

            x = 10;
            y = 20;
            Console.WriteLine("Data is changed !");
        }

    }
}
