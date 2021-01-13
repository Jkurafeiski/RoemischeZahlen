using System;

namespace RoemischeZahlen
{
    public class RomanNumberChecker
    {
        public RomanNumberChecker()
        {
          
        }
        public int RomanNumberConverter(char currentRoman, char nextRoman)
        {
            string key = currentRoman.ToString() + nextRoman.ToString();
            // var romanExOut = Roman.RomanSpecialDictionary[romanEx];
            if (Roman.RomanSpecialDictionary.TryGetValue(key, out var romanExOut))
            {
                return romanExOut;
            }
            else
            {
                return 0;
            }
        }
    }
}