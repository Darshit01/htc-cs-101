using System;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variables and do things with them!
          /*  int myNumber = 9001;
            double dNumber = 3.14;
            bool isRaining = false;
            string userName = "Just some random text";

            Console.WriteLine(myNumber);
            Console.WriteLine(dNumber);
            Console.WriteLine(isRaining);
            Console.WriteLine(userName);
*/
         /*Random numbers between 0-25 */
      /*   Random r = new Random();
       int rNumber = r.Next(0, 25);
       Console.WriteLine(rNumber);
        */    

        Random r1 = new Random();
        Random r2 = new Random();
        int rNumber = r1.Next(1,6);
        int rNumber2 = r2.Next(1,6);
        Console.WriteLine(rNumber);
        Console.WriteLine(rNumber2);
        int sumValue = rNumber + rNumber2;
        Console.WriteLine("The sum of two numbers is " + sumValue );


        }
    }
}
