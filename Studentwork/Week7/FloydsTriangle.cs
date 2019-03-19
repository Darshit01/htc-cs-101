using System;
namespace Week7_Floyd{
    class Floyd{
        public static void Main1(string[] args){
            Console.WriteLine("Enter the number of lines you want to print");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int x = 1;
            for( int i = 0; i <= userInput; i++){
                for (int j = 0; j <=i; j++){
                    Console.WriteLine(x + " ");
                    x++;
                    
                }
            }

        }
    }
}