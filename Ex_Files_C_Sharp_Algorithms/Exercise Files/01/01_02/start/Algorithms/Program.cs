using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {

        static Boolean isUpperCase(string s) {
            return s.All(char.IsUpper);
        }

        static Boolean isLowerCase(string s) {
            return s.All(char.IsLower);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isUpperCase("hello"));
            Console.WriteLine(isUpperCase("HELLO"));
            Console.WriteLine(isLowerCase("hello"));
            Console.WriteLine(isLowerCase("HELLO"));
        }
    }
}
