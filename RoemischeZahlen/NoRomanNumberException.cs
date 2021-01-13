using System;

namespace RoemischeZahlen
{
    public class NoRomanNumberException : Exception
    {
        public NoRomanNumberException(string message)
        : base(message)
        {
        }
    }
}