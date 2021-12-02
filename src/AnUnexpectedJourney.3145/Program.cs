using System;

namespace AnUnexpectedJourney._3145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberOfDwarvesAndDistance = Console.ReadLine();
            int numberOfDwarves = Convert.ToInt32(numberOfDwarvesAndDistance.Split(' ')[0]);
            int distance = Convert.ToInt32(numberOfDwarvesAndDistance.Split(' ')[1]);
            double timeToReachTheGoal = distance / (numberOfDwarves + 2.0);
            Console.WriteLine("{0:f2}", timeToReachTheGoal);
            Console.ReadLine();
        }
    }
}
