using System;

namespace exercise01_saying_hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}, nice to meet you! ");
            Console.ReadLine();
        }
    }
}
