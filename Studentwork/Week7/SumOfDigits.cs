using System;
namespace Week7_SumOfDigits
{

    class SumOfDigits
    {
        public static void Main3(string[] args)
        {
            Console.WriteLine("Enter the number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int x = 0;
            while (userInput > 0)
            {

                x = userInput % 10;
                sum = sum + x;
                userInput = userInput / 10;
            }
            Console.WriteLine(sum);
        }
    }
}


