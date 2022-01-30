using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static int hourglassSum(List<List<int>> arr)
        {
            List<int> localArray = new List<int>();
            List<int> finalArray = new List<int>();
        
            for(var i=0;i<4;i++)
            {
                for(var j=0;j<4;j++)
                {
                    localArray.Add(arr[i][j]);
                    localArray.Add(arr[i][j+1]);
                    localArray.Add(arr[i][j+2]);
                
                    localArray.Add(arr[i+1][j+1]);
                
                    localArray.Add(arr[i+2][j]);
                    localArray.Add(arr[i+2][j+1]);
                    localArray.Add(arr[i+2][j+2]);
                
                    finalArray.Add(localArray.Sum());
                    localArray.Clear();
                }
            }
            return finalArray.Max();
        }

    }
}