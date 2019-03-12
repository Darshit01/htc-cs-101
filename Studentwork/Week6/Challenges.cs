using System;
namespace Week6_Challenge{
    class Program{
        static void Main(string[] args){
            Random rnd = new Random();
            int rNumber = rnd.Next(1, 20);
            Console.WriteLine(rNumber);

            while (true){
                Console.WriteLine("Guess a number between 1 and 20: ");

                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == rNumber){
                    Console.WriteLine("Correct");
                    break;
                }else if (userInput < rNumber){
                    Console.WriteLine("Your guess is too low");
                }else{
                    Console.WriteLine("Your guess is too high");
                }
            }

        }
    }
}