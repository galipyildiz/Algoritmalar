using System;
using System.Diagnostics;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int[] dizi = { 7916, 7644, 5414, 8449, 2748, 9746, 6740, 5505, 887, 1365, 8751, 8654, 9016, 3104, 6360, 564, 5978, 6635, 2864, 8850, 3208, 1722, 8117, 8458, 5079, 2503, 9679, 8238, 3971, 8963, 6333, 336, 6755, 6144, 3837, 2340, 3590, 2353, 3629, 4777, 2421, 2978, 1884, 9779, 8347, 5545, 5570, 3807, 8206, 3883, 9724, 3418, 8275, 9280, 6050, 9573, 8143, 3239, 8142, 3965, 1453, 2812, 9666, 7410, 6814, 6935, 4561, 5744, 4075, 5220, 6334, 8793, 8043, 2816, 1767, 485, 7163, 4677, 1297, 4026, 4809, 2048, 5238, 4511, 657, 4009, 8459, 1986, 3126, 1595, 1114, 7427, 4616, 8104, 6917, 4946, 2887, 8998, 8554, 6752 };
            Console.WriteLine("Sıralanmamış");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            stopwatch.Start();
            InsertionSort(dizi, dizi.Length);
            stopwatch.Stop();
            Console.WriteLine("Sıralı");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            TimeSpan timespan = stopwatch.Elapsed;
            Console.WriteLine("Gecen Zaman: " + timespan.TotalMilliseconds + " saniye");
        }

        /// <summary>
        /// Genelde kart oyunlarında insanlar elindeki kartları sıralamak için farkında olmadan bu algoritmayı uygulamaktadır. O(N^2)
        /// </summary>
        private static void InsertionSort(int[] dizi, int n)
        {
            int deger;
            int j;
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                deger = dizi[i];
                j = i - 1;
                while (j >= 0 && dizi[j] > deger)
                {
                    count++;
                    dizi[j + 1] = dizi[j];
                    j--;
                }
                dizi[j + 1] = deger;
            }
            Console.WriteLine("Tekrar Sayısı: " + count);
        }
    }
}
