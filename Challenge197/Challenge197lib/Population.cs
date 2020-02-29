using System;

namespace de.aweleczka.to.dev.dailychallenge197.lib
{
    public class Population
    {

        /// <summary>
        /// Calculate the number of years for the population to grow from <paramref name="currentPopulation"/> 
        /// to <paramref name="populationGoal"/> with the givend parameters.
        /// </summary>
        /// <param name="currentPopulation">(p0) The starting population for the calculation</param>
        /// <param name="percentGrowth">(percent) The percental growth of the population.</param>
        /// <param name="generalFluctuation">(aug) The general fluctuation fo the population, independant of percental growth</param>
        /// <param name="populationGoal">(p) The population goal to be reached</param>
        /// <returns></returns>
        public static int NbYear(int currentPopulation, double percentGrowth, int generalFluctuation, int populationGoal)
        {
            double percent = percentGrowth / 100;

            int newPopulation = currentPopulation;
            int years = 0;

            while(newPopulation < populationGoal)
            {
                years++;
                newPopulation = NbYearCalc(newPopulation, percent, generalFluctuation);
            }

            return years;
        }

        /// <summary>
        /// Calculate a new population-value based on the passed parameters.
        /// </summary>
        /// <param name="currentPopulation">The starting population for the calculation</param>
        /// <param name="percentGrowth">The percental growth of the population - must be in decimal format! 2% = 0.02</param>
        /// <param name="generalFluctuation">The general fluctuation fo the population, independant of percental growth</param>
        /// <returns></returns>
        private static int NbYearCalc(int currentPopulation, double percentGrowth, int generalFluctuation)
        {
            int newPopulation = currentPopulation;
            newPopulation += (int) Math.Floor(currentPopulation * percentGrowth);
            newPopulation += generalFluctuation;

            return newPopulation;            
        }

    }
}
