
using System;
namespace Week3{
    class Exercise{
        static void Main2(string[] args){
            Console.WriteLine("Guess a number between 1 and 10");
        string input = Console.ReadLine();    
        int num = Convert.ToInt32(input);

        if (num > 4){
            Console.WriteLine("Too High!");
        }else if (num < 4){
            Console.WriteLine("Too Low");
        }else{
            Console.WriteLine("Just Right");
        }
        }
    }
}
