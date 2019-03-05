using System;

namespace Week4
{
    class CodeAlong
    
    {
        static void Main5(string[] args)
        {
            /* 
            bool snowOnGround = false;
            bool foundGloves =  true;
           
            if (snowOnGround == true && foundGloves == true){
                Console.WriteLine("I am going to build a snoman");
            }else{
                Console.WriteLine(" I am staying inside");
            }
            */

            bool snowOnGround = true;
            bool feelingSick = true;
            if (snowOnGround == true || feelingSick == true){
                
                Console.WriteLine("I am going to eat some soup");
            }else{
                Console.WriteLine("I don't want soup");
            }

        }
    }
}
