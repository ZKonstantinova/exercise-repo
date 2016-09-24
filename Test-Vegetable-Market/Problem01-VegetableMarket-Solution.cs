using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelenchukova_Borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegKg = int.Parse(Console.ReadLine());

            int fruitKilo = int.Parse(Console.ReadLine());
            double sumBG = (vegPrice * vegKg) + (fruitPrice * fruitKilo);

            int fruitKilo = int.Parse(Console.ReadLine());
            double sumBG = (vegePrice * vegKg) + (fruitPrice * fruitKg);

            double sumEUR = sumBG / 1.94 ;

            Console.WriteLine(sumEUR);





        }
    }
}
