using System;
using System.Collections.Generic;
using System.Text;

namespace RoemischeZahlen
{
    class Roman
    {
        public static readonly Dictionary<char, int> RomanDictionary;
        public static readonly Dictionary<string, int> RomanSpecialDictionary;
        static Roman()
        {

            RomanDictionary = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };

            RomanSpecialDictionary = new Dictionary<string, int>()
            {
                {"IV", 4},
                {"IX", 9},
                {"XL", 40},
                {"XC", 90},
                {"CD", 400},
                {"CM", 900},
            };
        }

        public int RomanMath(string romanInput)
        {
            var total = 0;
            for (int i = 0; i < romanInput.Length; i++)
            {
                var currentRoman = romanInput[i];
                int current;
                if (i == romanInput.Length - 1)
                {
                    current = Current(currentRoman);
                    total += current;
                    break;
                }
                var nextRoman = romanInput[i+1];
                current = Current(currentRoman);
                var next = RomanDictionary[nextRoman];

                if (next > current)
                {
                    int romanSpecial = new RomanNumberChecker().RomanNumberConverter(currentRoman, nextRoman);

                    total += romanSpecial;
                    i++;
                }
                else
                {
                    total += current;
                }
            }

            return total;
        }

        private int Current(char currentRoman)
        {
            if (!IsRoman(currentRoman))
            {
                throw new NoRomanNumberException("Das ist keine römische Zahl!");
            }

            var current = RomanDictionary[currentRoman];
            return current;
        }

        public bool IsRoman(char isRoman)
        {
            return RomanDictionary.TryGetValue(isRoman, out _);
        }

    }

}
