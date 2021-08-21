using System;

namespace TimeConversionHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "06:40:03AM";
            Console.WriteLine(TimeConversion(s));
        }
        public static string TimeConversion(string s)
        {
            string AMPM = s.Substring(s.Length - 2, 2);
            string result;
            int starts = Convert.ToInt32(s.Substring(0, 2));
            if (AMPM == "PM" && starts < 12)
            {
                starts += 12;
            }
            else if (AMPM == "AM" && starts >= 12)
            {
                starts -= 12;
            }
            else
            {
                result = s.Replace(AMPM, "");
                return result;
            }
            result = s.Replace(AMPM, "");
            if (starts == 24 || starts == 0)
            {
                return result.Replace(result.Substring(0, 2), "00");
            }
            return result.Replace(result.Substring(0, 2), starts.ToString());
        }
    }
}
