using System;
namespace Week7_PrimeNumber
{
    class PrimeNumber
    {
        public static void Main5(string[] args)
        {

            Console.WriteLine("Enter the number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //  int x = 0;
            for (int i = 2; i <= userInput / 2; i++)
            {
                if (userInput % i == 0)
                {

                    Console.WriteLine(userInput + " is not prime");


                }
                else
                {
                    Console.WriteLine(userInput + " is prime");
                    break;
                }
                //     x++;
            }


        }
    }
}