using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] massiv =
            {
                "Хлеб,35,Выпечка",
                "Клей,115,Ремонт",
                "Круассан,56,Выпечка",
                "Яблоки,89,Фрукты",
                "Апельсины,112,Фрукты",
                "Карандаш,23,Канцелярия",
                "Обои,500,Ремонт",
                "Ластик,54,Канцелярия",
                "Батон,45,Выпечка",
                "Груши,67,Фрукты",
                "Помидоры,89,Овощи",
                "Огурцы,78,Овощи",
                "Краска,450,Ремонт"
            };
            Console.WriteLine("Товары:");
            foreach(var i in massiv)
            {
                string[] prod = i.Split(',');
                Console.WriteLine($"  - {prod[0]}, по цене: {prod[1]}, из категории: {prod[2]}");
            }
            Console.WriteLine("Введите категорию товаров, которую хотите найти");
            string a = Console.ReadLine();
            Console.WriteLine($"{a}:");
            var kat = massiv.Where(b => b.Split(',')[2].ToLower().Contains(a.ToLower()));
            foreach (var k in kat)
            {
                Console.WriteLine($"  - {k.Split(',')[0]} по цене - {k.Split(',')[1]}");
            }
            Console.WriteLine("Введите минимальную цену товара:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную цену товара");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Товары в диапазоне от {min} до {max} рублей:");
            foreach(var i in massiv)
            {
                string[] part = i.Split(',');
                int zena1 = Convert.ToInt32(part[1]);
                if (zena1 >= min && zena1 <= max)
                {
                    Console.WriteLine($"  - {part[0]} по цене - {part[1]} из категории - {part[2]}");
                }
            }
            Console.WriteLine("Товары, отсортированные по цене:");
            var zena = massiv.OrderBy(b => Convert.ToInt32(b.Split(',')[1]));
            foreach(var z in zena)
            {
                Console.WriteLine($"  - {z.Split(',')[0]} по цене - {z.Split(',')[1]} из категории - {z.Split(',')[2]}");
            }
        }
    }
}
