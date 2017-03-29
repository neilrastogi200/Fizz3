using System;

namespace InformaFizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICalculation calculation = new Calculation();

            for (var i = 1; i <= 20; i++)
            {
                Console.WriteLine(calculation.DisplayNumber(i));
            }

            Console.WriteLine($"{"Fizz:" + calculation.FizzCount}");
            Console.WriteLine($"{"Buzz:" + calculation.BuzzCount}");
            Console.WriteLine($"{"FizzBuzz:" + calculation.FizzBuzzCount}");
            Console.WriteLine($"{"Lucky:" + calculation.LuckyCount}");
            Console.WriteLine($"{"Integer:" + calculation.NumberCount}");
        }
    }
}