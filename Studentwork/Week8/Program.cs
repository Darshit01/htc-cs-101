using System;

namespace Week8
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHat();
            InToCm();
            HiName();
            Console.WriteLine("Password plz");
            string input = Console.ReadLine();
            PasswordCheck(input);

            Console.WriteLine("Initial Price");
            double initPrice = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Coupon code");
            string userCode = Console.ReadLine();

            double x = CouponCode(initPrice, userCode);
            Console.WriteLine(x);


        }
        public static void PrintHat()
        {
            Console.WriteLine("   .--------.");
            Console.WriteLine("  /          ` .");
            Console.WriteLine(" |         .-.  .");
            Console.WriteLine(" |         |  `  .|");
            Console.WriteLine(" |_________|     <|>");
            Console.WriteLine("(___________)");
        }



        public static double InToCm()
        {
            Console.WriteLine("Give the measurement in inches");
            double inches = Convert.ToDouble(Console.ReadLine());
            double centimeters = inches * 2.54;
            double cm = centimeters;
            Console.WriteLine(cm);
            return cm;

        }

        public static string HiName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi," + name);
            return name;
        }

        public static void PasswordCheck(string password)
        {
            if (password == "bananas")
            {
                Console.WriteLine("Correct password");
            }
            else
            {
                Console.WriteLine("Incorrect password");
            }
        }

        public static double CouponCode(double intialPrice, string coupCode){
           
            if (coupCode == "PUNCH"){
                return intialPrice - (intialPrice * 0.15);
            }else if(coupCode == "HANDBOOK"){
                return intialPrice - (intialPrice * .25);
            }else{
                return intialPrice - (intialPrice * 1);
            }
        }

    }
}
