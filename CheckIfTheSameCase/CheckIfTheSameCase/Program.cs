using System;

namespace CheckIfTheSameCase
{
    class Program
    {
        public class IsLowerSample
        {
            public static bool SameCase(string str)
            {
                return str == str.ToUpper() | str == str.ToLower();
            }

            public static void Main()
            {
                Console.WriteLine(SameCase("hello"));
                Console.WriteLine(SameCase("HELLO"));
                Console.WriteLine(SameCase("Hello"));
                Console.WriteLine(SameCase("ketcHUp"));

                Console.ReadKey();
            }
        }
    }
}
