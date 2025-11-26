using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();
            Console.WriteLine("Массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            double sum = 0;
            int kolchet = 0;
            for (int i = 0;i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
                if (numbers[i] % 2 == 0)
                {
                    kolchet++;
                }
            }
            double average = Convert.ToDouble(sum / numbers.Length);
            Console.WriteLine($"Сумма всех элементов: {sum}");
            Console.WriteLine($"Среднее арифметическое: {average}");
            Console.WriteLine($"Кол-во четных чисел: {kolchet}");
        }
    }
}
