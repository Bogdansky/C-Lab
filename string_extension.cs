using System;

namespace MySpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            string word = "Hello, world!";
            Console.WriteLine(word.SymbolCount('.'));
        }
    }
    
    public static class StringExtension
    {
        public static int SymbolCount(this string word, char symbol, int start = 0, int counter = 0)
        {
            if (start == word.Length)
            {
                return counter;
            }
            return word[start++] == symbol ? SymbolCount(word, symbol, start, ++counter) : SymbolCount(word, symbol, start, counter);
        }
    }
}
