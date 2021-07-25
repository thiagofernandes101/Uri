using System;

namespace EvenOddPositiveAndNegative._1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEvenValues = 0;
            int numberOfOddValues = 0;
            int numberOfPositiveValues = 0;
            int numberOfNegativeValues = 0;

            int[] values = new int[5];

            for (int i = 0; i < 5; i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < values.Length; i++)
            {
                int value = values[i];

                if (value % 2 == 0)
                {
                    numberOfEvenValues++;
                }
                else
                {
                    numberOfOddValues++;
                }

                if (value > 0)
                {
                    numberOfPositiveValues++;
                }
                else if (value < 0)
                {
                    numberOfNegativeValues++;
                }
            }

            Console.WriteLine($"{numberOfEvenValues} valor(es) par(es)");
            Console.WriteLine($"{numberOfOddValues} valor(es) impar(es)");
            Console.WriteLine($"{numberOfPositiveValues} valor(es) positivo(s)");
            Console.WriteLine($"{numberOfNegativeValues} valor(es) negativo(s)");
        }
    }
}
