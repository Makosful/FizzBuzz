using System;
using CommandLine;

namespace Axl.Examples.FizzBuzz
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(Run);
        }

        private static void Run(Options options)
        {
            var fizz = options.Fizz;
            var buzz = options.Buzz;
            var fizzbuzz = fizz * buzz;

            for (var i = 1; i <= options.Count; i++)
            {
                string print = String.Empty;

                if (i % fizz == 0) print += "Fizz";
                if (i % buzz == 0) print += "Buzz";
                if (string.IsNullOrWhiteSpace(print)) print += $"{i}";

                Console.WriteLine(print);
            }
        }
    }
}
