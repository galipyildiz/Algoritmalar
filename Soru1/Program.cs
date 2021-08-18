using System;
using System.Diagnostics;

namespace Soru1
{
    /// <summary>
    /// 2. diziden sırayla seçilen elemanın ilk dizide küçük olan eleman sayılarını yazdır.
    /// 
    /// Örnek Girdi:
    /// 5 (1. dizi eleman adet) 
    /// 4 (2. dizi eleman adet)
    /// 1 3 5 7 9
    /// 6 4 2 8
    /// 
    /// Örnek Çıktı 1:
    /// 3 2 1 4
    /// 
    /// Açıklama:
    /// 6 elemanından küçük olanlar: 1,3,5 yani 3 eleman.
    /// 4 elemanından küçük olanlar: 1,3 -> 2 eleman.
    /// 2’den küçükler 1 -> 1 eleman.
    /// 8’den küçükler 1,3,5,7 -> 4 eleman
    /// Yani cevap: 3,2,1,4 olacaktır.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            int[] array2 = { 6, 4, 2, 8 };
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSort.Program.QuickSort(array1, 0, array1.Length - 1);
            Console.WriteLine("Sonuç");
            for (int i = 0; i < array2.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] > array1[j])
                    {
                        count++;
                    }
                }
                Console.Write(count + " ");
            }
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            Console.WriteLine();
            Console.WriteLine("Geçen süre: " + timeSpan.TotalMilliseconds);
        }
    }
}
