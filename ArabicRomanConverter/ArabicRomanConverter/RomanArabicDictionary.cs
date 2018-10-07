using System.Collections.Generic;

namespace ArabicRomanConverter
{
    public static class RomanArabicDictionary
    {
        public static Dictionary<string, int> dictionaryOfRomans = new Dictionary<string, int>()
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
}
    
    


