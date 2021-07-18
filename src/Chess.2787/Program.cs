using System;

namespace Chess._2787
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());

            bool isLineOddNumber = lines % 2 != 0;
            bool isColumnOddNumber = columns % 2 != 0;
            
            if (isLineOddNumber && isColumnOddNumber)
            {
                Console.WriteLine(1);
            }
            else if (!isLineOddNumber && isColumnOddNumber)
            {
                Console.WriteLine(0);
            }
            else if (isLineOddNumber && !isColumnOddNumber)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
