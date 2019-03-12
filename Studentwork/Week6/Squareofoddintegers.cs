using System;
namespace SquareIntegers_challenge{
    class SquareInterger{
        static void Main3(string[] args){
            int x = 1;
            while(x % 2 != 0 && x <= 50){
              
                Console.WriteLine(Math.Pow(x, 2));
                x += 2;
            }
        }
    }
}