using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i=i+1) // i++ = i=i+1  
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------");

            for (int i = 1; i <= 10; i+=2) // i+=2 = i=i+2   
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------");

            // Nested Loops
            for (int i = 1; i <=2 ; ++i) 
            {
                Console.WriteLine("Outer: " + i);

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Inner: " + j);
                }
            }
            Console.WriteLine("---------");

            int number1 = 11;
            while (number1 >=0)
            {
                Console.WriteLine(number1);
                number1--; // i-- = i - 1
            }
            Console.WriteLine("---------");

            int number2 = 11;
            do
            {
                Console.WriteLine(number2);
                number2-=2;

            } while (number2>=0);
            Console.WriteLine("---------");

            string[] countries= {"Turkey","Italy","Spain","England"};
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
            Console.ReadLine();
        }
    }
}
