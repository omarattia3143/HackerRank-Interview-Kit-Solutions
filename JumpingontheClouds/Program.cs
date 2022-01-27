using System;
using System.Collections.Generic;

namespace JumpingontheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>
            {
                0 ,0 ,0, 1, 0, 0
            };
            var result = jumpingOnClouds(list);

            Console.WriteLine(result);

        }


        public static int jumpingOnClouds(List<int> c)
        {
            int steps = 0;

            for (var i = 0; i < c.Count - 1;)
            {
                if (c.Count - i > 2)
                {
                    if (c[i + 2] == 0)
                    {
                        i += 2;
                        steps++;
                    }
                    else
                    {
                        i++;
                        steps++;
                    }
                }
                else
                {
                    if (c[i + 1] == 0)
                    {
                        steps++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return steps;
        }
    }
}