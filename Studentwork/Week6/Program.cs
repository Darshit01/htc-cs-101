﻿using System;

namespace Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the cap value: ");
            string value = Console.ReadLine();
            int userInput = Convert.ToInt32(value);
            int x = 0;

            while (x <= userInput){
            if (x % 2 == 0){
                Console.WriteLine(x);
            }
            x++;
            
            }
        }
    }
}
