using System;
using System.Linq;

namespace RoemischeZahlen
{
    public class RomanLengthCheck
    {
        public RomanLengthCheck()
        {
           
        }
        public bool LengthCheckerBool(string input)
        {
            if (!RomanLengthChecker(input))
            {
                Console.WriteLine("Zu viele gleiche Zeichen!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool RomanLengthChecker(string romanLengthChecker)
        {
            if (romanLengthChecker.Contains("IIII") || romanLengthChecker.Contains("XXXX") || romanLengthChecker.Contains("CCCC") || romanLengthChecker.Contains("VV") ||
                romanLengthChecker.Contains("LL") || romanLengthChecker.Contains("DD") || romanLengthChecker.Contains("IIV") || romanLengthChecker.Contains("IIX") || 
                romanLengthChecker.Contains("IIC") || romanLengthChecker.Contains("IIL") || romanLengthChecker.Contains("IID") || romanLengthChecker.Contains("IIM") ||
                romanLengthChecker.Contains("XXC") || romanLengthChecker.Contains("XXL") || romanLengthChecker.Contains("XXD") || romanLengthChecker.Contains("XXM") ||
                romanLengthChecker.Contains("CCM") )
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