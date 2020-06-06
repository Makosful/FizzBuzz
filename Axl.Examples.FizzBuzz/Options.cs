using CommandLine;

namespace Axl.Examples.FizzBuzz
{
    public class Options
    {
        [Option ('f', Required = true, HelpText = "The count on which to call Fizz")]
        public int Fizz { get; set; }

        [Option ('b', Required = true, HelpText = "The count on which to call Buzz")]
        public int Buzz { get; set; }

        [Option ('c', Required = true, HelpText = "The number to count to")]
        public int Count { get; set; }
    }
}
