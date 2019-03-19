using System;
namespace Week7_CodeAlong
{
    class CodeAlong
    {
        public static void Main5(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");

                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}