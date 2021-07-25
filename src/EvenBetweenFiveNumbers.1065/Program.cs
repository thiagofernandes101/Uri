using System;

namespace EvenBetweenFiveNumbers._1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenCounter = 0;

            for (int i = 0; i < 5; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());

                if (value % 2 == 0)
                {
                    evenCounter++;
                }
            }

            Console.WriteLine($"{evenCounter} valores pares");
        }
    }
}
