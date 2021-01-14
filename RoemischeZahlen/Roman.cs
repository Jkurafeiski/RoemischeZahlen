using System;
using System.Collections.Generic;

namespace RoemischeZahlen
{
    public class Roman
    {
        private readonly Dictionary<string, int> RomanDictionary;
        private readonly Dictionary<string, int> RomanSpecialDictionary;
        public Roman()
        {
            var comparer = StringComparer.OrdinalIgnoreCase;
            RomanDictionary = new Dictionary<string, int>(comparer)
            {
                {"I", 1},
                {"V", 5},
                {"X", 10},
                {"L", 50},
                {"C", 100},
                {"D", 500},
                {"M", 1000},
            };

            RomanSpecialDictionary = new Dictionary<string, int>(comparer)
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
            romanInput = romanInput.ToUpper();
            if (!LengthCheckerBool(romanInput))
            {
                throw new NoRomanNumberException("Zu viele gleiche Zeichen!");
            }

            var nextRoman = 'I';
            var total = 0;
            for (int i = 0; i < romanInput.Length; i++)
            {
                if (i < romanInput.Length-1)
                {
                    nextRoman = romanInput[i + 1];
                }
                var currentRoman = romanInput[i];
                string nextString = Convert.ToString(nextRoman);
                string currentString = Convert.ToString(currentRoman);
                int current;
                if (i == romanInput.Length - 1)
                {
                    current = Current(currentString, nextString);
                    total += current;
                    break;
                }
                current = Current(currentString, nextString);
                var next = RomanDictionary[nextString];

                if (next > current)
                {
                    var romanSpecial = RomanNumberConverter(currentRoman, nextRoman);

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

        private int Current(string currentRoman, string nextRoman)
        {
            if (!IsRoman(currentRoman) || !IsRoman(nextRoman))
            {
                throw new NoRomanNumberException("Das ist keine römische Zahl!");
            }
            var current = RomanDictionary[Convert.ToString(currentRoman)];
            return current;
        }

        private bool IsRoman(string isRoman)
        {
            return RomanDictionary.TryGetValue(isRoman, out _);
        }

        private int RomanNumberConverter(char currentRoman, char nextRoman)
        {
            string key = currentRoman.ToString() + nextRoman.ToString();
            if (RomanSpecialDictionary.TryGetValue(key, out var romanExOut))
            {
                return romanExOut;
            }
            else
            {
                return 0;
            }
        }

        private bool LengthCheckerBool(string input)
        {
            return RomanLengthChecker(input);
        }

        private bool RomanLengthChecker(string romanLengthChecker)
        {
            if (romanLengthChecker.Contains("IIII") || romanLengthChecker.Contains("XXXX") || romanLengthChecker.Contains("CCCC") || romanLengthChecker.Contains("VV") ||
                romanLengthChecker.Contains("LL") || romanLengthChecker.Contains("DD") || romanLengthChecker.Contains("IIV") || romanLengthChecker.Contains("IIX") ||
                romanLengthChecker.Contains("IIC") || romanLengthChecker.Contains("IIL") || romanLengthChecker.Contains("IID") || romanLengthChecker.Contains("IIM") ||
                romanLengthChecker.Contains("XXC") || romanLengthChecker.Contains("XXL") || romanLengthChecker.Contains("XXD") || romanLengthChecker.Contains("XXM") ||
                romanLengthChecker.Contains("CCM"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
