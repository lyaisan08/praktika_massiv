using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 12.5, 56.3, 23.45, 67.7, 67.5, 8.6, 4.56, 5.7, 89.3, 12.4, 11.45, 3.5, 6.8, 56.4, 34.8 };
            Console.WriteLine("Массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "; ");
            }
            Console.WriteLine();
            double min = numbers[0];
            double max = numbers[0];
            double sum = 0;
            for(int i  = 0; i < numbers.Length;i++)
            {
                sum += numbers[i];
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            double average = sum / numbers.Length;
            Console.WriteLine($"Минимальный элемент: {min}. Максимальный элемент: {max}");
            Console.WriteLine($"Разность между максимальным и минимальным: {max - min}.");
            Console.WriteLine("Cреднее арифметическое:" + average);
            Console.WriteLine("Элементы, которые больше среднего арифметического:");           
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > average)
                {
                    Console.Write(numbers[i] + "; ");
                }
            }
        }
    }
}
