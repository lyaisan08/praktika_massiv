using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = new int[30];
            Random random = new Random();
            Console.WriteLine("Температура за месяц");
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = random.Next(-35, 36);
                Console.Write(massiv[i] + "  ");
                if ((i + 1) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            int hotwek = -1000;
            int coldwek = 1000;
            int maxn = 1;
            int minn = 1;
            for (int w = 0; w < 4; w++)
            {
                int sumw = 0;
                for (int day = 0; day < 7; day++)
                {
                    int dayi = w * 7 + day;
                    if (dayi < massiv.Length)
                    {
                        sumw += massiv[dayi];
                    }
                }
                if (sumw > hotwek)
                {
                    hotwek = sumw;
                    maxn = w + 1;
                }
                if (sumw < coldwek)
                {
                    coldwek = sumw;
                    minn = w + 1;
                }
            }
            Console.WriteLine($"Самая теплая неделя: {maxn}, с температурой: {hotwek}");
            Console.WriteLine($"Самая холодная неделя: {minn}, с температурой: {coldwek}");
            var av = massiv.Average();
            Console.WriteLine($"Средняя температура за месяц: {av:F1}");
            Console.WriteLine("Дни, когда температура была выше средней:");
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] > av)
                {
                    Console.WriteLine($" - день {i + 1} с температурой {massiv[i]}");

                }
            }
            Console.WriteLine("Группировка температур:");
            int moroz = 0;// ниже 0
            int holodno = 0;// от 0 до 10
            int teplo = 0;// от 11 до 25
            int zharko = 0;// выше 25
            foreach(var i in  massiv)
            {
                if(i < 0)
                {
                    moroz++;
                }
                else if(i >= 0 && i <= 10)
                {
                    holodno++;
                }
                else if(i >= 11 && i <= 25)
                {
                    teplo++;
                }
                else
                    zharko++;
            }
            Console.WriteLine($" - мороз {moroz} дней");
            Console.WriteLine($" - холодно {holodno} дней");
            Console.WriteLine($" - тепло {teplo} дней");
            Console.WriteLine($" - жарко {zharko} дней");
        }
    }
}
