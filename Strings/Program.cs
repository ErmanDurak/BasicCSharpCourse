using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro();

            string firstName = "Mustafa Kemal";
            string lastName = "ATATÜRK";
            string name = $"Full name is {firstName} {lastName}";

            string sentence = "Hello World!";
            var result1 = sentence.Length;
            bool result2 = sentence.EndsWith("!");
            bool result3 = sentence.StartsWith("h");
            var result4 = sentence.IndexOf("o");
            var result5 = sentence.LastIndexOf("r");
            var result6 = sentence.Insert(5, " Fucking");
            var result7 = sentence.Substring(6,3);
            var result8 = sentence.ToLower();
            var result9 = sentence.ToUpper();
            var result10 = sentence.Replace(" ","*");
            var result11 = sentence.Remove(2, 1);
            string txt = ("Hello \"fucking\" World");


            Console.WriteLine(txt);
            Console.ReadLine();
        }

        private static void Intro()
        {
            String City = "Istanbul";

            Console.WriteLine(City[0]);
            Console.WriteLine();

            foreach (var word in City)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();

            string city2 = "Berlin";
            string result = City + " " + city2;
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine(String.Format("{0} {1}", City, city2));
        }
    }
}
