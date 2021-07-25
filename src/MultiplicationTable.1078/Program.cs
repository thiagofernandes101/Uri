using System;

namespace MultiplicationTable._1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {value} = {i * value}");
            }
        }
    }
}
