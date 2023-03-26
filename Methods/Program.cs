using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void run()
        {

            Console.WriteLine("run forest run!");

        }

        static int sum(int number1, int number2)
        {

            int result = number1 + number2;
            return result;

        }

        static int sum2(int number1, int number2 = 31)
        {

            int result = number1 + number2;
            return result;

        }

        static int multiply(int number1, int number2) 
        {
        
            return number1 * number2;   
        
        }

        static int multiply(int number1, int number2, int number3)
        {

            return number1 * number2 * number3;

        }

        static void Main(string[] args)
        {
            run();
            run();
            run();
            int result = sum(31, 69);
            int result2 = sum(13579, 24680);
            int result3 = sum2(73);
            int result4 = multiply(31, 69);
            int result5 = multiply(31, 52, 69);
            Console.WriteLine("the first number is: " + result);
            Console.WriteLine("the second number is: " + result2);
            Console.WriteLine("the third number is: " + result3);
            Console.WriteLine("the fourth number is: " + result4);
            Console.WriteLine("the fifth number is: " + result5);
            Console.ReadLine();

        }

        


    }
}
