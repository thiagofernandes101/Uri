using System;

namespace SumOfConsecutiveOddNumbersII._1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sumOfOddNumbersBetweenXandY = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] entry = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(entry[0]);
                int y = Convert.ToInt32(entry[1]);

                if (y < x)
                {
                    x = x + y;
                    y = x - y;
                    x = x - y;
                }

                for (int j = x + 1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        sumOfOddNumbersBetweenXandY[i] += j;
                    }
                }
            }

            foreach(int value in sumOfOddNumbersBetweenXandY)
            {
                Console.WriteLine(value);
            }
        }
    }
}
