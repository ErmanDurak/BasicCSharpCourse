using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 71;
            if (number1 == 71)
            {
                Console.WriteLine("number is 71");
            }
            else if (number1 > 71)
            {
                Console.WriteLine("number is bigger than 71");
            }
            else
            {
                Console.WriteLine("number is smaller than 71");
            }

            switch (number1)
            {
                case 13:
                    Console.WriteLine("number is 13");
                    break;
                case 93:
                    Console.WriteLine("number is 93");
                    break;
                default:
                    Console.WriteLine("number is unknown");
                    break;
            }

            Console.WriteLine(number1 == 25 ? "Number is 25" : "Number is not 25");
            

            if (number1 >= 0 && number1 <= 100) 
            {
                Console.WriteLine("number is between 0-100");
            }
            else if (number1 > 100 && number1 <= 200) //&& = and
            {
                Console.WriteLine("number is between 100-200");
            }
            else if (number1 > 200 || number1 < 0) // || = or
            {
                Console.WriteLine("number is less than 0 or greater than 200");
            }


            Console.ReadLine();
        }
    }
}
