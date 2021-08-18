using System;
using System.Diagnostics;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch(); 
            int[] dizi = { 13, 63, 437, 440, 467, 564, 696, 762, 807, 1060, 1091, 1559, 1595, 1731, 1905, 1981, 2178, 2219, 2355, 2407, 2417, 2455, 2477, 2501, 2648, 2750, 2769, 2994, 3114, 3159, 3251, 3358, 3419, 3590, 3596, 3729, 3738, 3742, 3772, 3810, 3876, 3884, 4077, 4222, 4364, 4381, 4545, 4586, 4610, 4737, 4891, 4984, 5009, 5048, 5127, 5174, 5328, 5377, 5559, 5647, 5650, 5818, 5821, 5872, 5977, 6016, 6328, 6487, 6538, 6587, 6601, 6887, 6967, 6980, 6989, 7069, 7123, 7269, 7324, 7391, 7458, 7500, 7674, 7880, 7958, 8097, 8134, 8253, 8347, 8373, 8449, 8605, 8866, 8898, 8954, 9084, 9154, 9493, 9730, 9914 };
            int bas = 0;
            int son = dizi.Length - 1;
            int deger = 8373;//dizide aranan değer.
            stopwatch.Start();
            int sonuc = BinarySearch(dizi, bas, son, deger,0);
            stopwatch.Stop();
            Console.WriteLine(sonuc);
            Console.WriteLine(dizi[sonuc]);
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            TimeSpan timespan = stopwatch.Elapsed;
            Console.WriteLine("Gecen Zaman: " + timespan.TotalMilliseconds + " saniye");
        }
        /// <summary>
        /// Binary Search en temel arama algoritmalarından biridir. Ancak bu algoritmayı kullanabilmek için dizimizin küçükten büyüğe sıralı olması gerek. O(log N)
        /// </summary>
        private static int BinarySearch(int[] dizi, int bas, int son, int deger,int count)
        {
            count++;
            Console.WriteLine(count);
            if (son >= bas)
            {
                int orta = (bas + son) / 2;
                if (dizi[orta] == deger)
                {
                    return orta;
                }
                else if (dizi[orta] > deger)
                {
                    return BinarySearch(dizi, bas, orta - 1, deger,count);
                }
                else
                {
                    return BinarySearch(dizi, orta + 1, son, deger,count);
                }
            }
            return -1;
        }
    }

}
