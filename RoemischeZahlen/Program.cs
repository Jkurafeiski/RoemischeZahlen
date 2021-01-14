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
    }
}
