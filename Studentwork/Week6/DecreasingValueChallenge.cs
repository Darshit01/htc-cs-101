 using System;
 namespace Challenges_DecreasingValue{
     class decreasingValue{
         static void Main3 (string[] args){


              Console.WriteLine("Enter a number: ");
            double xValue = Convert.ToDouble(Console.ReadLine());

            while (xValue >= 0){
                Console.WriteLine(xValue);
                 xValue -= 0.5;
            }

         }
     }
 }
 
 
