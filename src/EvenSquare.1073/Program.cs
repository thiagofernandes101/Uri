using System;

namespace EvenSquare._1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine($"{i}^2 = {Math.Pow(i, 2.0)}");
            }
        }
    }
}
