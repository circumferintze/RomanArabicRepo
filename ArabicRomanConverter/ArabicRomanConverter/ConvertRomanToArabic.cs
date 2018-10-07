using System.Linq;

namespace ArabicRomanConverter
{
    public static class ConvertRomanToArabic
    {
        public static int Convert(string inputRoman)
        {
            int arabic = 0;
            for (int i = 0; i < inputRoman.Count(); i++)
            {
                if (!RomanArabicDictionary.dictionaryOfRomans.ContainsKey(inputRoman[i].ToString()))
                    return 0;
                if (i == inputRoman.Count() - 1)
                {
                    arabic += RomanArabicDictionary.dictionaryOfRomans[inputRoman[i].ToString()];
                }
                else
                {
                    if (RomanArabicDictionary.dictionaryOfRomans[inputRoman[i + 1].ToString()] > RomanArabicDictionary.dictionaryOfRomans[inputRoman[i].ToString()])
                        arabic -= RomanArabicDictionary.dictionaryOfRomans[inputRoman[i].ToString()];
                    else arabic += RomanArabicDictionary.dictionaryOfRomans[inputRoman[i].ToString()];
                }
            }
            return arabic;
        }

    }


}
    
    


