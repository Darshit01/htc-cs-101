using System;
namespace Week7_SumSeries{
    class SumSeries{
        public static void Main (string[] args){
            Console.WriteLine("Enter a number");
            
            int userInput = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int x = 1;
            for (int i = 1; i <= userInput; i++){
                sum = sum + x;
                x = (x * 10) + 1;
                
            }
            Console.WriteLine(sum);
        }
    }
}