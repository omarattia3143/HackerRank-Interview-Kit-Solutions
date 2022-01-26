using System;
using System.Collections.Generic;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            var result =  countingValleys(8, "UDDDUDUU");

            Console.WriteLine(result);        
        }
        
        
        public static int countingValleys(int steps, string path)
        {
            int upCounter = 0;
            int downCounter = 0;
            int valleryCounter = 0;
            List<char> combination = new List<char>();
        
            for(var i=0;i<steps;i++)
            {
                combination.Add(path[i]);
            
                if(path[i] == 'U')
                    upCounter++;
                
                if(path[i] == 'D')
                    downCounter++;
                
                
                if(upCounter == downCounter && combination[0] == 'U')
                {
                    combination.Clear();
                    continue;
                }
                
                if(upCounter == downCounter && combination[0] == 'D')
                {
                    valleryCounter++;
                    combination.Clear();
                }
            }
        
            return valleryCounter;
        }
    }
}