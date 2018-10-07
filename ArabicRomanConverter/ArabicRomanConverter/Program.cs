using System;
using System.Text;
using System.Threading.Tasks;

namespace ArabicRomanConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter roman numerals");
            string s = Console.ReadLine().ToUpper();
            ConvertRomanToArabic.Convert(s);
            Console.ReadKey();
        }
    }


}
    
    


