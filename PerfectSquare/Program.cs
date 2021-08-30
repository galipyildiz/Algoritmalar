using System;

namespace PerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            CheckPerfectSquare(x);
        }
        /// <summary>
        /// 7*7 = 49 && math.sqrt(49) * math.sqrt(49) = 49, 49 is perfect square
        /// </summary>
        /// <param name="x">integer</param>
        /// <returns>void</returns>
        static void CheckPerfectSquare(int x)
        {
            if (Math.Ceiling((double)Math.Sqrt(x)) == Math.Floor((double)Math.Sqrt(x)))
            {
                Console.WriteLine("perfect square");
            }
            else
            {
                Console.WriteLine("not a perfect square");
            }
        }
    }
}
