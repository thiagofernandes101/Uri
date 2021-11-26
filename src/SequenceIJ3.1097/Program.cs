using System;

namespace SequenceIJ3._1097
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 7;

            for (int i = 1; i <= 9; i+=2)
            {
                for (int counter = 1; counter <= 3; counter++)
                {
                    Console.WriteLine($"I={i} J={j}");
                    j--;
                }

                j += 5;
            }
        }
    }
}
