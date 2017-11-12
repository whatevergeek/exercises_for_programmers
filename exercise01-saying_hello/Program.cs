using System;

namespace exercise01_saying_hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            Console.WriteLine($"Hello, {Console.ReadLine()}, nice to meet you! ");
            Console.ReadLine();
        }
    }
}
