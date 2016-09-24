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
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegKg = int.Parse(Console.ReadLine());
            int fruitKg = int.Parse(Console.ReadLine());
            double sumBG = (vegPrice * vegKg) + (fruitPrice * fruitKg);
            double sumEUR = sumBG / 1.94 ;

            Console.WriteLine(sumEUR);





        }
    }
}
