using System;
using System.Collections.Generic;
using System.Linq;

namespace StairsHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 16;
            StairCase(n);
        }
        /// <summary>
        /// n adet kadar merdiven şeklinde # yazdırma console'a.
        /// </summary>
        /// <param name="n"></param>
        public static void StairCase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int boslukAdet = n - i;
                for (int j = 0; j < boslukAdet; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
