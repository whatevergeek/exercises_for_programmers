using static System.Console;

namespace exercise02_counting_the_number_of_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProcess();
        }

        private static void StartProcess()
        {
            Write("What is the input string? ");
            var input = ReadLine();

            if (input.Length == 0)
            {
                WriteLine("User must enter something into the program.");
                StartProcess();
            }
            else
            {
                WriteLine($"{input} has {input.Length} characters.");
                ReadLine();
            }
        }
    }
}
