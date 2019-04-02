using System;
namespace codeAlong
{

    class codeAlong
    {
        static void Main1(string[] args)
        {

            PrintSmileys(10);
        }

        public static void PrintSmileys(int numTimes)
        {

            for (int i = 0; i < numTimes; i++)
            {
                Console.WriteLine(":)");
            }
        }
    }
}