using System;
using System.Collections.Generic;


namespace Week9
{
    class Program
    {

        static void Main1(string[] args)
        {
            List<string> toDoList = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a command:");
                string command = Console.ReadLine();
                if (command == "Add")
                {
                    Console.WriteLine("Enter an item: ");
                    string item = Console.ReadLine();
                    toDoList.Add(item);
                    

                }
                else if (command == "View")
                {
                    ViewList(toDoList);
                }
                else if (command == "Exit")
                {
                    break;
                }
            }
        }

        public static void ViewList(List<string> str)
        {
            int x = str.Count;
            
            Console.WriteLine(x);
            Console.WriteLine("To do: ");
            foreach (string item in str){
                Console.WriteLine("-" + item);
                

            }
        }
    }
}
