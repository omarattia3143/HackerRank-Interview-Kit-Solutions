using System;
using System.Collections.Generic;
using System.Linq;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>
            {
                0, 0, 0, 1, 0, 0
            };
            var result = repeatedString("aba", 10);

            Console.WriteLine(result);
        }

        public static long repeatedString(string s, long n)
        {
            if (s.All(x => x != 'a'))
                return 0;
            
            
            var numberOfInitialLetter = s.Count(x => x == 'a');
            
            if ( n % s.Length == 0)
            {
                return  numberOfInitialLetter * (n/s.Length);
            }

            int counter = 0;
            var remainingLettersFromLastIterations =  n - ((n / s.Length) * s.Length);

            for (var i = 0; i < remainingLettersFromLastIterations; i++)
            {
                if (s[i] == 'a')
                {
                    counter++;
                }
            }
                
            return  numberOfInitialLetter * (n/s.Length) + counter;
        }
    }
}