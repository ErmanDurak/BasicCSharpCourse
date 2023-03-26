using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] cars = new string[5];
            cars[0] = "Audi";
            cars[1] = "Mercedes";
            cars[2] = "Skoda";
            cars[3] = "Nissan";
            cars[4] = "Dodge";


            string[] cars2 = { "BMW", "Toyota", "Ford" };

            foreach (var car in cars) 
            {
                Console.WriteLine(car);                           
            }

            Console.WriteLine();

            foreach (var car2 in cars2)
            {
                Console.WriteLine(car2);
            }

            Console.WriteLine();

            string[,] regions = new string[7, 3]
            {
                {"İstanbul","Kocaeli","Edirne" },
                {"İzmir","Muğla","Aydın" },
                {"Antalya","Adana","Mersin" },
                {"Ankara","Konya","Kayseri" },
                {"Zonguldak","Samsun","Artvin" },
                {"Kars","Ağrı","Van" },
                {"Şanlıurfa","Mardin","Gaziantep" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("***");
            }


            Console.ReadLine();

        }
    }
}
