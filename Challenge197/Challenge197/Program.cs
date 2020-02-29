using de.aweleczka.to.dev.dailychallenge197.lib;
using System;

namespace de.aweleczka.to.dev.dailychallenge197
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Polulation Calculator 9001");
            Console.WriteLine();

            int currentPopulation = Program.ReadCurrentPopulation();

            double percentalGrowth = Program.ReadPercentalGrowth();

            int generalFluctuation = Program.ReadGeneralFluctuation();

            int targetPopulation = Program.ReadTargetPopulation();

            Console.WriteLine();
            Console.WriteLine($"NbYear({currentPopulation}, {percentalGrowth}, {generalFluctuation}, {targetPopulation});");

            int years = Population.NbYear(currentPopulation, percentalGrowth, generalFluctuation, targetPopulation);
            Console.WriteLine($"It takes a total of {years} years");

            Console.WriteLine();
            Console.WriteLine("'c' to continue, anything else to quit");
            ConsoleKeyInfo input = Console.ReadKey();
            if(input.Key == ConsoleKey.C)
            {
                Console.Clear();
                Program.Main(args);
            }
        }

        /// <summary>
        /// Read and parse the current population from stdin.<br/>
        /// Re-Calls itself if a parsing-error occured.
        /// </summary>
        /// <returns>The parsed integer value for current population</returns>
        private static int ReadCurrentPopulation()
        {
            Console.Write("Enter current population: ");
            string currentPopulation = Console.ReadLine();

            try
            {
                return int.Parse(currentPopulation);
            }
            catch
            {
                Console.WriteLine($"Invalid input: '{currentPopulation}'");
                return Program.ReadCurrentPopulation();
            }
        }

        /// <summary>
        /// Read and parse the percental growth from stdin.<br/>
        /// Re-Calls itself if a parsing-error occured.
        /// </summary>
        /// <returns>The parsed double value for percental growth</returns>
        private static double ReadPercentalGrowth()
        {
            Console.Write("Enter percental growth per year: ");
            string percentalGrowth = Console.ReadLine();

            try
            {
                return double.Parse(percentalGrowth);
            }
            catch
            {
                Console.WriteLine($"Invalid input: '{percentalGrowth}'");
                return Program.ReadPercentalGrowth();
            }
        }

        /// <summary>
        /// Read and parse the general fluctuation from stdin.<br/>
        /// Re-Calls itself if a parsing-error occured.
        /// </summary>
        /// <returns>The parsed integer value for general fluctuation</returns>
        private static int ReadGeneralFluctuation()
        {
            Console.Write("Enter general fluctuation per year: ");
            string generalFluctuation = Console.ReadLine();

            try
            {
                return int.Parse(generalFluctuation);
            }
            catch
            {
                Console.WriteLine($"Invalid input: '{generalFluctuation}'");
                return Program.ReadGeneralFluctuation();
            }
        }

        /// <summary>
        /// Read and parse the target population from stdin.<br/>
        /// Re-Calls itself if a parsing-error occured.
        /// </summary>
        /// <returns>The parsed integer value for target population</returns>
        private static int ReadTargetPopulation()
        {
            Console.Write("Enter your target population: ");
            string targetPopulation = Console.ReadLine();

            try
            {
                return int.Parse(targetPopulation);
            }
            catch
            {
                Console.WriteLine($"Invalid input: '{targetPopulation}'");
                return Program.ReadTargetPopulation();
            }
        }
    }
}
