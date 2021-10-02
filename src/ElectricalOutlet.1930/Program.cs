using System;

namespace ElectricalOutlet._1930
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberOfTakenFromEachFourStrips = Console.ReadLine().Split(' ');
            int maximumNumberOfDevicesThatCanBeConnected = 0;

            for(int i = 0; i < numberOfTakenFromEachFourStrips.Length; i++)
            {
                if (i == numberOfTakenFromEachFourStrips.Length - 1)
                {
                    maximumNumberOfDevicesThatCanBeConnected += Convert.ToInt32(numberOfTakenFromEachFourStrips[i]);
                }
                else
                {
                    maximumNumberOfDevicesThatCanBeConnected += Convert.ToInt32(numberOfTakenFromEachFourStrips[i]) - 1;
                }
            }

            Console.WriteLine(maximumNumberOfDevicesThatCanBeConnected);
        }
    }
}
