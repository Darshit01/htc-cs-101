using System;

namespace Week3
{
    class Program
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("What grade are you in?");
            int studentGrade = Convert.ToInt32(Console.ReadLine());

            if(studentGrade <= 5 ){
            
                Console.WriteLine("You are in Elementary school");       
            }
            else if (studentGrade <= 8)
            {
                Console.WriteLine("You are in middle school");
            
            }else if (studentGrade <= 12){
            
                Console.WriteLine("You are in High School");
            }else{
                Console.WriteLine("You maybe in college");
            }

        }
    }
}
