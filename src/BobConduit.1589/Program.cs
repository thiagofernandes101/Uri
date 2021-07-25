using System;

namespace BobConduit._1589
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] circularConduitsRadius = new int[t];

            for (int i = 0; i < t; i++)
            {
                string[] testCase = Console.ReadLine().Split(' ');
                circularConduitsRadius[i] = Convert.ToInt32(testCase[0]) + Convert.ToInt32(testCase[1]);
            }

            foreach (int circularConduitRadius in circularConduitsRadius)
            {
                Console.WriteLine(circularConduitRadius);
            }
        }
    }
}
