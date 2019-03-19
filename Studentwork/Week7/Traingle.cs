using System;
namespace Week7_Traingle
{
    class Traingle
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Enter the height");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= userInput; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("");
                }
                for (int x = 1; x <= i; x++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");

            }
            Console.ReadLine();
        }
    }
}