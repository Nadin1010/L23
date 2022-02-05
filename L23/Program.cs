using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L23
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialAsync(); //вызов асинхронного метода
            Console.WriteLine("Введите число:   ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа равен {n * n}");
            Console.ReadKey();
        }

        static void Factorial()
        {
            int result = 1;
            for (int i = 1; i < 8; i++)
            {
                result *= i;

                Thread.Sleep(7000);
            }
            Console.WriteLine($"Факториал равен {result}");
        }

        static async void FactorialAsync()
        {
            Console.WriteLine("Начало метода FactorialAsync"); //выполняется синхронно

            await Task.Run(() => Factorial()); //выполняется асинхронно
            Console.WriteLine("Конец метода FactorialAsync");
        }

    }
}
       
       