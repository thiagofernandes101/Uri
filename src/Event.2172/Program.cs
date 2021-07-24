using System;
using System.Collections.Generic;

namespace Event._2172
{
    class Program
    {
        static void Main(string[] args)
        {
            string testCase;
            List<double> exps = new List<double>();

            for (; ; )
            {
                testCase = Console.ReadLine();

                if (testCase != "0 0")
                {
                    double x = Convert.ToDouble(testCase.Split(' ')[0]);
                    double m = Convert.ToDouble(testCase.Split(' ')[1]);
                    double expIncrease = x * m;

                    exps.Add(expIncrease);
                }
                else
                {
                    break;
                }
            }

            exps.ForEach(value => Console.WriteLine(value));
        }
    }
}
