using System;

namespace Week7
{
    class Program
    {
        static void Main4(string[] args)
        {

            Console.WriteLine("Enter the bottom number");
            int bottomNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the top number");
            int topNumber = Convert.ToInt32(Console.ReadLine());



            int result = 0;
            for (int i = bottomNumber; i <= topNumber; i++)
            {
                result += i;

            }
            Console.WriteLine(result);
        }
    }
}
