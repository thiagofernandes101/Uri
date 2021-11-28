using System;
using System.Collections.Generic;
using System.Linq;

namespace Ages._1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();
            int age = 0;

            while (age >= 0)
            {
                age = Convert.ToInt32(Console.ReadLine());

                if (age >= 0)
                {
                    ages.Add(age);
                }
            }

            double ageAverage = ages.Sum() / (ages.Count() * 1.0);
            Console.WriteLine("{0:f2}", ageAverage);
            Console.ReadLine();
        }
    }
}
