using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMaxSumHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>(){ 1123123, 212312312, 3123123, 1231231234, 12312315 };
            MinMaxSum(arr);
        }
        /// <summary>
        /// 5 elemanlı bir listenin 4 elemanının minimum ve maksimum toplamı.
        /// </summary>
        /// <param name="arr"></param>
        public static void MinMaxSum(List<int> arr)
        {
            int min = arr.Min();
            int max = arr.Max();
            arr.Remove(max);
            long minSum = 0;
            long maxSum = 0;
            foreach (var item in arr)
            {
                minSum += item;
            }
            Console.Write(minSum);
            arr.Add(max);
            arr.Remove(min);
            Console.Write(" ");
            foreach (var item in arr)
            {
                maxSum += item;
            }
            Console.Write(maxSum);
        }
    }
}
