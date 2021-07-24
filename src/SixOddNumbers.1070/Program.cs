using System;

namespace SixOddNumbers._1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                x += 1;
            }

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine(x);
                x += 2;
            }
        }
    }
}
