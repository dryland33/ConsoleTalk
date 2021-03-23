using System;

namespace ConsoleTalk
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Say something.");
            string input = Console.ReadLine();
            if (input.EndsWith(".") || input.EndsWith("?") || input.EndsWith("!"))
                Console.WriteLine($"You said, \"{ input}\"");
            else
                Console.WriteLine($"You said, \"{ input}\".");
        }
    }
}
