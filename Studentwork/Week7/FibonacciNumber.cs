using System;
namespace Week7_Fibonacci
{
    class Fibonacci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int count = Convert.ToInt32(Console.ReadLine());

            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;

            Console.WriteLine(fib1);
            Console.WriteLine(fib2);

            for (int i = fib1; i <= count; i++)
            {

                fib3 = fib1 + fib2;
                Console.WriteLine(fib3);
                fib1 = fib2;
                fib2 = fib3;
            }
        }
    }
}
