using System;
using System.Collections.Generic;

namespace CorrectAnswer._3302
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> answers = new List<string>();
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int entry = Convert.ToInt32(Console.ReadLine());

                answers.Add($"resposta {i}: {entry}");
            }

            answers.ForEach(answer => Console.WriteLine(answer));
        }
    }
}
