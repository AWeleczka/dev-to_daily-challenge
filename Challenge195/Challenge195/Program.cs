using de.aweleczka.to.dev.dailychallenge195.lib;
using System;

namespace de.aweleczka.to.dev.dailychallenge195
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daily Challenge #195 - No Zeroes for Heroes");
            Console.WriteLine();
            Console.WriteLine("It has officially been decided that numbers that end with zeroes are boring.");
            Console.WriteLine("They might be fun in your world, but definitely not here.");
            Console.WriteLine("Implement a function to eradicate any trailing zeroes.");
            Console.WriteLine("If the given number is 0, just leave him alone.");
            Console.WriteLine();
            Console.WriteLine("Poor guy anyway...");
            Console.WriteLine();
            Console.WriteLine("Therefore, from now one it shall be:");
            Console.WriteLine($"9070 is {9070.StripTrailingZeros()}");
            Console.WriteLine($"210000 is {210000.StripTrailingZeros()}");
            Console.WriteLine($"10210 is {10210.StripTrailingZeros()}");
            Console.WriteLine($"but 0 will remain {0.StripTrailingZeros()}");

            Console.ReadLine();
        }
    }
}
