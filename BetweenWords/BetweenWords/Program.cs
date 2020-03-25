using System;

namespace BetweenWords
{
    class Program
    {
        public static bool isBetween(string first, string last, string word)
        {
            return first.CompareTo(word) == -1 && last.CompareTo(word) == 1;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(isBetween("apple", "banana", "azure"));
            Console.ReadKey();
        }
    }
}
