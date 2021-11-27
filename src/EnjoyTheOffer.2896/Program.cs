using System;

namespace EnjoyTheOffer._2896
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            int[] testsResult = new int[numberOfTestCases];

            for (int i = 0; i < numberOfTestCases; i++)
            {
                string entryValues = Console.ReadLine();
                int numberOfSoftDrinksBought = Convert.ToInt32(entryValues.Split(' ')[0]);
                int numberOfEmptyBottlesToGainAFull = Convert.ToInt32(entryValues.Split(' ')[1]);

                if (numberOfEmptyBottlesToGainAFull > numberOfSoftDrinksBought)
                {
                    testsResult[i] = numberOfSoftDrinksBought;
                }
                else
                {
                    int numberOfExchangesBottles = Convert.ToInt32(Math.Floor(numberOfSoftDrinksBought / numberOfEmptyBottlesToGainAFull * 1.0));
                    int numberOfBottlesLeft = numberOfSoftDrinksBought - (numberOfExchangesBottles * numberOfEmptyBottlesToGainAFull);

                    if (numberOfBottlesLeft > 0)
                    {
                        testsResult[i] = numberOfBottlesLeft + numberOfExchangesBottles;
                    }
                    else
                    {
                        testsResult[i] = numberOfExchangesBottles;
                    }
                }
            }

            foreach (int result in testsResult)
            {
                Console.WriteLine(result);
            }
        }
    }
}
