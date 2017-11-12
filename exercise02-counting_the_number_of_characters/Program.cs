using static System.Console;

namespace exercise02_counting_the_number_of_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("What is the input string? ");
            var input = ReadLine();
            WriteLine($"{input} has {input.Length} characters.");
            ReadLine();
        }
    }
}
