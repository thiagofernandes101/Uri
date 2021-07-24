using System;

namespace PepeIAlreadyTookTheCandle._2152
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCases = Convert.ToInt32(Console.ReadLine());
            string[] logCases = new string[numberOfCases];

            for (int i = 0; i < numberOfCases; i++)
            {
                logCases[i] = Console.ReadLine();
            }

            for (int i = 0; i < logCases.Length; i++)
            {
                string[] logCase = logCases[i].Split(' ');
                
                DateTime hourMinuteLog = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(logCase[0]), Convert.ToInt32(logCase[1]), 0);
                string doorState = Convert.ToInt32(logCase[2]) == 0 ? "A porta fechou!" : "A porta abriu!";

                Console.WriteLine($"{hourMinuteLog:HH:mm} - {doorState}");
            }
        }
    }
}
