using System;

namespace SchoolFloor._2786
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int firstTypeTiles = (l * c) + ((l - 1) * (c - 1));
            int secondTypeTiles = (2 * (l - 1)) + (2 * (c - 1));

            if (firstTypeTiles < 0)
            {
                firstTypeTiles = 0;
            }

            if (secondTypeTiles < 0)
            {
                secondTypeTiles = 0;
            }

            Console.WriteLine(firstTypeTiles);
            Console.WriteLine(secondTypeTiles);
        }
    }
}
