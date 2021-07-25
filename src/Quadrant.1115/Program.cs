using System;

namespace Quadrant._1115
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] testCase = Console.ReadLine().Split(' ');
                
                int x = Convert.ToInt32(testCase[0]);
                int y = Convert.ToInt32(testCase[1]);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
