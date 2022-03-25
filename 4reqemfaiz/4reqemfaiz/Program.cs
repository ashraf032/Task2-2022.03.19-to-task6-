using System;

namespace _4reqemfaiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir 4 reqemli eded verin");
            string num1 = Console.ReadLine();

            int a = int.Parse(num1);

            double b = a / 100 * 20;


            double c = b / 100 * 10;

            if (a >= 1000 && a < 10000)
            {
                Console.WriteLine($"{c * c}");
            }
            else
            {
                Console.WriteLine("Bu hall nezere alinmayib");
            }
        }
    }
}
