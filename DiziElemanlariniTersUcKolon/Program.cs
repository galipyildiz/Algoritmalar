using System;

namespace DiziElemanlariniTersUcKolon
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitKey = "";
            while (exitKey != "q")
            {
                Random rnd = new Random();
                int[] sayiDiziTekEleman = new int[rnd.Next(20)];

                for (int i = 0; i < sayiDiziTekEleman.Length; i++)
                {
                    sayiDiziTekEleman[i] = rnd.Next(5000);
                }
                string dizi = "Dizi=>";
                for (int i = 0; i < sayiDiziTekEleman.Length; i++)
                {
                    dizi += sayiDiziTekEleman[i] + " ";
                }
                Console.WriteLine(dizi);
                Console.WriteLine("Dizi uzunluğu: " + sayiDiziTekEleman.Length);
                if (sayiDiziTekEleman.Length % 3 == 0)
                {
                    for (int i = sayiDiziTekEleman.Length - 3; i > -2; i -= 3)
                    {
                        Console.WriteLine(sayiDiziTekEleman[i] + "\t " + sayiDiziTekEleman[i + 1] + "\t " + sayiDiziTekEleman[i + 2]);
                    }
                }
                else
                {
                    int kalan = sayiDiziTekEleman.Length % 3;
                    Console.WriteLine($"KALAN: {kalan}");
                    if (kalan == 2)
                    {
                        for (int i = sayiDiziTekEleman.Length - 3; i > 0; i -= 3)
                        {
                            Console.WriteLine(sayiDiziTekEleman[i] + "\t " + sayiDiziTekEleman[i + 1] + "\t " + sayiDiziTekEleman[i + 2]);
                        }
                        Console.WriteLine("\t " + sayiDiziTekEleman[0] + "\t " + sayiDiziTekEleman[1]);
                    }
                    else if (kalan == 1)
                    {
                        for (int i = sayiDiziTekEleman.Length - 3; i > 0; i -= 3)
                        {
                            Console.WriteLine(sayiDiziTekEleman[i] + "\t " + sayiDiziTekEleman[i + 1] + "\t " + sayiDiziTekEleman[i + 2]);
                        }
                        Console.WriteLine("\t\t " + sayiDiziTekEleman[0]);
                    }
                }
                Console.WriteLine("Çıkmak için q basınız devam etmek için herhangibir tuşa basınız.");
                exitKey = Console.ReadLine();
            }
        }
    }
}
