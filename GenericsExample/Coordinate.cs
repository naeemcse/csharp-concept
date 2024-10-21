using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    //single data Type
    public class Coordinate<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
    }
    // multiple Data Type

    public class Coordinate2<T, U>
    {
        public T A { get; set; }
        public U B { get; set; }
    }


    public class BubbleShort<T> where T: INumber<T>
    {
        public T[] Sort(T[] arr)
        {
            T tem;
            for (int i = 0; i<=arr.Length-2; i++)
            {
                for(int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                     tem = arr[j+1]; 
                        arr[j+1] = arr[j];
                        arr[j] = tem;
                        
                    }
                }

            }

            return arr;
        }

    }


}
