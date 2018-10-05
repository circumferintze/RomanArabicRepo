using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicRomanConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= Console.ReadLine();
            var a = RomanNumbers.C;
                Console.WriteLine("a");


        }
    }
    public static class RomanArabicMap
    {
        public static Dictionary<string, int> map = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5},
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 }
        };
    }
    static class ConvertRomanToArabic
    {
        public static int Convert(this string s)
        {
            int result;
            if (s == "" || s == null) result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var arabic = RomanArabicMap.map[s[i].ToString()];
                for (int j = i + 1; j < s.Length; j++)
                {
                    if
                }
            }
            
            return result;
            
        }
        

    }
    static class ConvertArabicToRoman
    {

    }
    
    //enum RomanNumbers
    //{
    //    I = 1,
    //    V = 5,
    //    X = 10,
    //    L = 50, 
    //    C = 100,
    //    D = 500,
    //    M = 1000
    //}
    

}
