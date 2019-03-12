using System;

namespace Week5{
    class calculator{
         public static double MultiplyNumber( double integer1, double integer2){
            return integer1 * integer2;
        }

        public static double DivideNumber (double integer1, double integer2 ){
            return integer1/integer2;
        }

        public static double AddNumber(double integer1, double integer2){
            return integer1 + integer2;
        }

        public static double SubtractNumber(double integer1 , double integer2){
            return integer1 - integer2; 
        }
        public static void QuadraticFormula(double a, double b, double c, out double x1, out double x2){
            double insideSquareRoot = (b * b) - 4 * a * c;
            if(insideSquareRoot < 0){
                x1 = double.NaN;
                x2 = double.NaN;
            }else{
                double sqrt = Math.Sqrt(insideSquareRoot);
                x1 = (-b + sqrt) / (2 * a);
                x2 = (-b - sqrt) / (2 * a);
            }
            
        }

        public static void Main5 (string[] args){
            
            double returnValue = 0;
           // double out1 = 0;
           // double out2 = 0;
            Console.WriteLine("Enter a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter c:");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What operation to perform (+, -, *, /)");
            string ops = Console.ReadLine();

            if(ops == "+"){
               returnValue = AddNumber(a, b);
            }else if(ops == "-"){
                returnValue = SubtractNumber(a, b);
            }else if(ops == "*"){
                returnValue = MultiplyNumber(a, b);
            }else if(ops == "/"){
                returnValue = DivideNumber(a, b);
            }else{
            
            }
            Console.WriteLine(returnValue);
           
        
        }    
       
    
    
    }
}