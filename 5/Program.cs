using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string[] massiv =
            {
                "Иванова София Дмитриевна,Директор",
                "Катичев Михаил Андреевич,Менеджер",
                "Кошкин Степан Владимирович,Программист",
                "Петрова Александра Васильевна,Бухгалтер",
                "Зайцев Василий Степанович,Веб-дизайнер",
            };
            Console.WriteLine("Все сотрудники: ");
            foreach(var i in massiv)
            {
                string[] part = i.Split(',');
                Console.WriteLine($"  - {part[0]} - {part[1]}");
            }
            Console.WriteLine("Введите должность сотрудника, которого хотите найти");
            string a = Console.ReadLine();
            Console.WriteLine("Сотрудник с этой должностью:");
            var dolgnost = massiv.Where(b => b.Split(',')[1].ToLower() == a.ToLower());
            foreach(var dol in dolgnost)
            {
                Console.WriteLine($"  - {dol.Split(',')[0]}");
            }
            Console.WriteLine("Введите букву, по которой хотите найти сотрудника");
            string c = Console.ReadLine();
            Console.WriteLine("Имена сотрудников, начинающиеся с этой буквы:");
            var name = massiv.Where(b => b.ToLower().StartsWith(c.ToLower()));
            foreach (var n in name)
            {
                Console.WriteLine($"  - {n}");
            }
            Console.WriteLine("Отсортированный список сотрудников по алфавиту:");
            Array.Sort(massiv);
            foreach (var sor in massiv)
            {
                Console.WriteLine($"  - {sor}");
            }
        }
    }
}
