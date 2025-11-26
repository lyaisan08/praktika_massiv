using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[31];
            Random random = new Random();
            Console.WriteLine("Результаты тестирования:");
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = random.Next(1, 101);
                Console.Write(test[i] + " ");
            }
            Console.WriteLine();
            Array.Sort(test);            
            Console.WriteLine("Отсортированный результаты по возрастанию:");
            foreach(var tes in  test)
            {
                Console.Write(tes + " ");
            }
            Console.WriteLine();
            int median = 0;
            if (test.Length % 2 == 0)
            {
                median = (test[test.Length / 2 - 1] + test[test.Length / 2]) / 2;
            }
            else
                median = test[test.Length / 2];
            Console.WriteLine($"Медиана: {median}");
            var aver = test.Average(b => b);
            double sum2 = 0;
            for (int i = 0; i < test.Length; i++)
            {
                double a = test[i] - aver;
                a = Math.Pow(a, 2);
                sum2 += a;
            }
            double average2 = sum2 / test.Length;
            double stan = Math.Sqrt(average2);
            Console.WriteLine($"Стандартное отклонение : {stan:F2}");
            Console.WriteLine("Топ 10 % лучших результатов:");
            var result = test.OrderByDescending(b => Convert.ToInt32(b)).Take(3);
            foreach(var r in result)
            {
                Console.WriteLine($"  - {r} ");
            }
            int otlichno = 0;
            int horosho = 0;
            int udov = 0;
            int ploho = 0;
            foreach(var i in test)
            {
                if(i >= 90)
                {
                    otlichno++;
                }
                else if(i >= 75 && i <= 89)
                {
                    horosho++;
                }
                else if(i >= 50 && i <= 74)
                {
                    udov++;
                }
                else
                    ploho++;
            }
            Console.WriteLine("Распределение по оценками:");
            Console.WriteLine($"На Отлично (выше 90) написали: {otlichno} студентов");
            Console.WriteLine($"На Хорошо (от 75 до 89) написали: {horosho} студентов");
            Console.WriteLine($"На Удовлетворительно (от 50 до 74) написали: {udov} студентов");
            Console.WriteLine($"На Плохо (ниже 50) написали: {ploho} студентов");
        }
    }
}
