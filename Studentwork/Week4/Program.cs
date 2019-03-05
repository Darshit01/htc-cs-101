using System;

namespace Week4
{
    class Program
    {
        static void Main7(string[] args)
        {
         Console.WriteLine("Input a day");
         string whichDay = Console.ReadLine();
         
         Console.WriteLine("Input time of the day");
         string timeOfDay = Console.ReadLine();
         int input = Convert.ToInt32(timeOfDay);
         Console.WriteLine("Input length of parking time");
         
         string partTime = Console.ReadLine();
         int inputParkTime = Convert.ToInt32(partTime);
         

            if (inputParkTime >=4 && inputParkTime <= 7){
                Console.WriteLine("NO Stopping");
            }else if ((whichDay == "saturday" || whichDay == "sunday") && (inputParkTime >= 0 && inputParkTime <=7)){
                Console.WriteLine("No parking. Tow Away zone");
            }else if(whichDay == "saturday" || whichDay == "friday" && (input >=18 && input < 0) && (inputParkTime <= 120)){
                Console.WriteLine("You can park for two hours");
            }else if((whichDay == "monday" || whichDay == "tuesday" || whichDay == "wednesday" || whichDay == "thursday") && (input >=22 && input <= 2) && (inputParkTime <= 240)){
                Console.WriteLine("You can park for 4 hours");
            }else {
                Console.WriteLine("You can park for 2 hours");
            }

        
        }
    }
}

