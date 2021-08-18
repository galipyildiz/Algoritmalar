using System;
using System.Diagnostics;

namespace QuickSort
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
            QuickSort(dizi, 0, dizi.Length - 1);
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
        /// Quick Sort, bilgisayarda tuttuğumuz verileri belli bir düzene göre sıralamamızı sağlayan bir algoritmadır. Biz her bir adımda rastgele bir eleman seçiyoruz. Daha sonra diziyi baştan sona gezerek bu elemandan küçük olanları sola, büyük olanları sağa atıyoruz. Böylelikle seçtiğimiz elemandan küçük bütün sayılar solda, büyük sayılar ise sağda kalmış oluyor.O(N log2(N))
        /// </summary>
        private static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        /// <summary>
        /// bir eleman seçerek diziyi bu elamanın küçükleri sola, büyükleri sağa gelecek şekilde yeniden şekillenmesini sağlıyor. Daha sonra Böl ve Fethet yöntemini kullanarak önce sol tarafı sıralıyor, sonra sağ tarafı kendi içinde sıralıyor.
        /// </summary>
        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;
            return i + 1;
        }
    }
}
