using System;
using System.Collections.Generic;

namespace challenge
{
    class challenges
    {
        public static void Main1(string[] args)
        {
            addToList();
            addNames();
            palindromeCheck();
        }

        public static void addToList()
        {
            List<int> myList = new List<int>();
            myList.Add(2);
            myList.Add(4);
            myList.Add(6);
            myList.Add(8);
            myList.Add(10);
            myList.ForEach(Console.WriteLine);
        }

        public static void addNames()
        {
            List<string> str = new List<string>();
            str.Add("Alice");
            str.Add("Bob");
            str.Add("Charles");
            str.Add("Danielle");
            str.Add("Edgar");
            str.Add("Frannie");
            Console.WriteLine("Enter a name to add: ");
            string input = Console.ReadLine();
            str.Add(input);
            str.ForEach(Console.WriteLine);

            Console.WriteLine("Enter a name: ");
            string uInput = Console.ReadLine();
            foreach (string i in str)
            {
                if (uInput == i)
                {
                    Console.WriteLine(uInput + "already exists");
                }
                else
                {
                    Console.WriteLine(uInput + " is not in the list");

                }
            }
        }


        public static void palindromeCheck()
        {
            string x, y = "";
            Console.WriteLine("What is the string");
            x = Console.ReadLine();

            int length = x.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                y = y + x[i];


            }
            if (x.Equals(y))
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }
        }
    }

}





