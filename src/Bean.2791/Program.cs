using System;

namespace Bean._2791
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entry = Console.ReadLine().Split(' ');

            for (int i = 0; i < entry.Length; i++)
            {
                if (entry[i] == "1")
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}
