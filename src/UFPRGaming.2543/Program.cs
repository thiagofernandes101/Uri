using System;

namespace UFPRGaming._2543
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testCase = string.Empty;

            while (testCase != "EOF")
            {
                testCase = Console.ReadLine();

                if (testCase == "EOF")
                {
                    break;
                }

                int numberOfGameplaysPublished = Convert.ToInt32(testCase.Split(' ')[0]);
                long studentUniversityId = Convert.ToInt32(testCase.Split(' ')[1]);
                int numberOfContraStrikeVideosPublished = 0;

                for (int i = 0; i < numberOfGameplaysPublished; i++)
                {
                    string videoDescription = Console.ReadLine();
                    bool isAuthorUniversityId = Convert.ToInt32(videoDescription.Split(' ')[0]) == studentUniversityId;
                    bool isContraStrikeGameplay = Convert.ToInt32(videoDescription.Split(' ')[1]) == 0;

                    if (isAuthorUniversityId && isContraStrikeGameplay)
                    {
                        numberOfContraStrikeVideosPublished++;
                    }
                }

                Console.WriteLine(numberOfContraStrikeVideosPublished);
            }

            Console.ReadLine();
        }
    }
}
