using System;
using System.Diagnostics;

namespace MergeSort
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
            int[] yeniDizi = MergeSort(dizi);
            stopwatch.Stop();
            
            Console.WriteLine("Sıralı");
            for (int i = 0; i < yeniDizi.Length; i++)
            {
                Console.Write(yeniDizi[i] + " ");
            }
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            TimeSpan timespan = stopwatch.Elapsed;
            Console.WriteLine("Gecen Zaman: " + timespan.TotalMilliseconds + " saniye");
        }
        /// <summary>
        /// Divide and Conquer(Böl ve Yönet) yaklaşımının en temel örneklerinden biri olan Merge Sort, sıralayacağımız diziyi her seferinde ikiye bölüp ayrı ayrı sıraladıktan sonra birleştirme mantığına dayanmaktadır. Algoritmamız iki fonksiyondan oluşuyor. Birincisi girilen diziyi ikiye bölüp ayrı ayrı sıralamayı sağlarken diğeri sıralanmış iki diziyi birleştirmemizi sağlıyor. O(N * log(N))
        /// </summary>
        private static int[] MergeSort(int[] dizi)
        {

            int x = 0;
            int y = 0;
            int middle = dizi.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[middle];
            int[] result = new int[dizi.Length];

            if (dizi.Length <= 1)
            {
                return dizi;
            }

            for (int i = 0; i < middle; i++)
            {
                left[x] = dizi[i];
                x++;
            }
            for (int i = middle; i < dizi.Length - 1; i++)
            {
                right[y] = dizi[i];
                y++;
            }
            left = MergeSort(left);
            right = MergeSort(right);
            result = Merge(left, right);
            return result;
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int x = 0;
            int y = 0;
            int k = 0;
            while (left.Length > x && right.Length > y)
            {
                if (left[x] <= right[y])
                {
                    result[k] = left[x];
                    x++;
                    k++;
                }
                else
                {
                    result[k] = right[y];
                    y++;
                    k++;
                }
            }

            if (left.Length > x)
            {
                while (x < left.Length)
                {
                    result[k] = left[x];
                    x++;
                    k++;
                }
            }

            if (right.Length > y)
            {
                while (y < right.Length)
                {
                    result[k] = right[y];
                    y++;
                    k++;
                }
            }
            return result;
        }
    }
}
