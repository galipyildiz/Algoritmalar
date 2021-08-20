using System;
using System.Diagnostics;

namespace EratosthenesKalburu
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SieveOfErastosthenes(100);
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            Console.WriteLine("\n" + timeSpan.TotalMilliseconds);

        }
        /// <summary>
        /// 1’den 10^7’ye kadar olan asal sayıların tümünü bulmamızı sağlar.
        /// Prime diye bir bool veri tipinde dizi tanımlıyoruz. Başlangıçta bu dizinin bütün elemanlarını true yapıyoruz. Algoritmanın sonunda yalnızca asal olan sayıların true olmasını istiyoruz ve asal olmayanlara false değerini atamaya çalışıyoruz.
        ///Algoritmanın temel mantığını anlatmak gerekirse bir asal sayı alıyoruz ve biz biliyoruz ki bu asal sayının hiçbir tam katı asal değildir.Örnek vermek gerekirse 5 bir asal sayıdır ancak 5 in tam katları olan 10,15,20,25… şeklinde giden sayıların hiçbiri asal değildir. O(N)
        /// </summary>
        private static void SieveOfErastosthenes(int n)
        {
            bool[] prime = new bool[n + 1];
            for (int i = 0; i < n; i++)
            {
                prime[i] = true;
            }
            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * 2; i <= n; i += p)
                    {
                        prime[i] = false;
                    }
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
