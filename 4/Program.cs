using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15];
            Random random = new Random();
            int count = 0;
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 11);
                Console.Write(numbers[i] + "; ");
                if (numbers[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine();
            int[] numbers2 = new int[count];
            int a = 0;  
            Console.WriteLine("Массив без нулей");
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    numbers2[a] = numbers[i];
                    a++;
                }
            }
            for(int i = 0; i < numbers2.Length; i++)
            {
                Console.Write(numbers2[i] + "; ");
            }
        }
    }
}
