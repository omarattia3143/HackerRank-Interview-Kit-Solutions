using System;
using System.Collections.Generic;

namespace HackerRank.InterviewKit
{
    class Program
    {
        static void Main(string[] args)
        {
           var result =  sockMerchant(10, new List<int>
            {
                1, 1, 3, 1,
                2,
                1,
                3,
                3,
                3,
                3
            });

           Console.WriteLine(result);
        }


        public static int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int counter = 0;

            for (var i = 0; i < n; i++)
            {
                if (dict.ContainsKey(ar[i]))
                {
                    if (++dict[ar[i]] == 2)
                    {
                        dict.Remove(ar[i]);
                        counter++;
                    }
                }
                else
                {
                    dict.Add(ar[i], 1);
                }
            }

            return counter;
        }
    }
}