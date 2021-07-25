using System;

namespace HoHoHo._1759
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine("Ho!");
                }
                else
                {
                    Console.Write("Ho ");
                }
            }
        }
    }
}
