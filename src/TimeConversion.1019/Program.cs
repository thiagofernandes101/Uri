using System;

namespace TimeConversion._1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = Convert.ToInt32(Console.ReadLine());
            
            int hour = Convert.ToInt32(Math.Floor((double)seconds / 3600));
            seconds %= 3600;

            int minutes = Convert.ToInt32(Math.Floor((double)seconds / 60));
            seconds %= 60;

            Console.WriteLine($"{hour}:{minutes}:{seconds}");
        }
    }
}
