using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>() { 75, 67, 40, 33 };
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// 1- Bir not listesinde notun bir sonraki 5'in katı olan sayıdan, notun kendisi çıkarıldığında kalan 3'den küçükse not bir sonraki 5'in katı olan sayıya yuvarlanır. Küçük değilse yuvarlanmaz.
        /// 2- 38'den küçükse yuvarlanmaz.
        /// Not: 84 - Bir Sonraki 5'in katı olan Sayı: 85 (85 - 84 = 3'den küçük YUVARLANIR.)
        /// Not: 29 (38'den küçük yuvarlanmaz.)
        /// Not: 57 (60 - 57 = 3'den küçük değil yuvarlanmaz.)
        /// </summary>
        private static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            foreach (var item in grades)
            {
                if (item < 38)
                {
                    result.Add(item);
                }
                else
                {
                    for (int i = 100; i >= 0; i -= 5)
                    {
                        if (item > i)
                        {
                            int sonuc = (i + 5) - item;
                            if (sonuc < 3)
                            {
                                result.Add(i + 5);
                            }
                            else
                            {
                                result.Add(item);
                            }
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
