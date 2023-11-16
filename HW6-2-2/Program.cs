using System;

namespace SumInRange
{
    class Program
    {
        static int SumBetween(int a, int b)
        {
            int sum = 0;
            int start = Math.Min(a, b);
            int end = Math.Max(a, b);

            
            for (int i = start; i <=end; i++)
            {
                sum += i;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = SumBetween(num1, num2);
            Console.WriteLine($"Сумма чисел в диапазоне между {num1} и {num2} равна {result}");
        }
    }
}
