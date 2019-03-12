using System;
namespace SumChallenge
{
    class Sums_Challenge
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the number of positive integers you want to add: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
              //  int x = n;
               // x += --x;

               
                sum += n;
                 n--;

                Console.WriteLine(sum);






            }



        }

    }
}
