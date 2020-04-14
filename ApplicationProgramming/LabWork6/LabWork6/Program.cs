using System;
using System.Collections.Generic;

namespace LabWork6
{
    class Program
    {      
        static void Main(string[] args)
        {
            List<int> digits = new List<int>();

            Random random = new Random();

            Console.WriteLine("Сколько чисел сгенирировать?");

            int numberDigits = int.Parse(Console.ReadLine());
            Console.WriteLine("Начальный list:");
            while (numberDigits > 0)
            {
                numberDigits--;
                int number = random.Next(0, 30);

                bool isPrime = true;
                Console.Write(number + " ");
                for (int i = 2; i <= (Math.Sqrt(Math.Abs(number))); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (!isPrime)
                {
                    digits.Add(number);
                }
            }

            Console.WriteLine("\nУдалим все простые числа, получим: ");
            digits.ForEach(digit => Console.Write(digit + " "));

            Console.ReadLine();
        }
    }
}
