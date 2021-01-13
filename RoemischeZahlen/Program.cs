using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace RoemischeZahlen
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schreibe mir eine Römische Zahl");
            string input = Console.ReadLine();

            bool checker = new RomanLengthCheck().LengthCheckerBool(input);
            if (checker)
            {
                try
                {
                    var Output = new Roman().RomanMath(input);
                    Console.WriteLine(Output);
                }
                catch (NoRomanNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Ups da ist was Schief gelaufen versuche es erneut !");
            }

        }
    }
}
