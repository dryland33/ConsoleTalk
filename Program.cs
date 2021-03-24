using System;
using System.Runtime.InteropServices;

namespace ConsoleTalk
{
    class Program
    {
        static void Main(string[] args) {
            Console.Title = "ConsoleTalk";
            const int BeepFrequencyInHz = 800;
            const int BeepDurationInMs = 200;
            BeepSample.scale();
            //for (int i = 0; i < 3; i++) {
                //Console.Beep();
                //Interop.Kernel32.Beep(BeepFrequencyInHz, BeepDurationInMs);
            //}
            bool carryOn = true;
            Console.WriteLine("Enter Q to quit.\n");
            while (carryOn) {
                Console.WriteLine("Say something.");
                string input = Console.ReadLine();
                if (input == "Q") { carryOn = false; continue; }
                else if (input.EndsWith(".") || input.EndsWith("?") || input.EndsWith("!"))
                    Console.WriteLine($"You said, \"{ input}\"\n");
                else
                    Console.WriteLine($"You said, \"{ input}\".\n");
            }
        }
    }
}


class BeepSample
{
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool Beep(uint dwFreq, uint dwDuration);

    public static void Beeping() {
        Console.WriteLine("Testing PC speaker...");
        uint i = 110;
        while (i <= 10000) {
            Beep(i, 300);
            i = (uint)Math.Floor(i * Math.Sqrt(2));
        }
        Console.WriteLine("Testing complete.");
    }
    public static void scale() {
        Beep(262, 1000);
        Beep(294, 1000);
        Beep(330, 1000);
        Beep(349, 1000);
        Beep(392, 1000);
        Beep(440, 1000);
        Beep(494, 1000);
        Beep(523, 1000);
        Beep(262 * 2, 1000);
        Beep(294 * 2, 1000);
        Beep(330 * 2, 1000);
        Beep(349 * 2, 1000);
        Beep(392 * 2, 1000);
        Beep(440 * 2, 1000);
        Beep(494 * 2, 1000);
        Beep(523 * 2, 1000);
        Beep(523 * 2, 1000);
        Beep(494 * 2, 1000);
        Beep(440 * 2, 1000);
        Beep(392 * 2, 1000);
        Beep(349 * 2, 1000);
        Beep(330 * 2, 1000);
        Beep(294 * 2, 1000);
        Beep(262 * 2, 1000);
        Beep(523, 1000);
        Beep(494, 1000);
        Beep(440, 1000);
        Beep(392, 1000);
        Beep(349, 1000);
        Beep(330, 1000);
        Beep(294, 1000);
        Beep(262, 1000);
    }
}

