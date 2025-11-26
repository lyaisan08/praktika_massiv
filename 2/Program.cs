using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] slova = new string[5];
            for(int i = 0; i < slova.Length; i++)
            {
                Console.WriteLine("Хотите ввести слово сами? (да/нет)");
                string a = Console.ReadLine();
                if (a == "да")
                {
                    slova[i] = Console.ReadLine();
                }
                else if(a == "нет")
                {
                    slova[i] = "ничего";
                    Console.WriteLine(slova[i]);
                }
            }
            Console.WriteLine("Массив:");
            for(int i = 0; i < slova.Length; i++)
            {
                Console.Write(slova[i] + ", ");
            }
            Console.WriteLine();
            string maxdlina = slova[0];
            int dlina = slova[0].Length;
            for (int i = 1;i < slova.Length; i++)
            {
                if (slova[i].Length > maxdlina.Length)
                {
                    maxdlina = slova[i];
                    dlina = slova[i].Length;
                }
            }
            Console.WriteLine($"Самая длинная строка: {maxdlina}. Длина этой строки {dlina}");
            Console.WriteLine("Введите букву, по которой хотите найти слова в массиве");
            string d = Console.ReadLine() ;
            Console.Write("Слова, содержащие эту букву: ");
            for(int i = 0; i < slova.Length; i++)
            {
                string b = slova[i];
                if(b != "ничего")
                {
                    for(int j = 0; j < b.Length; j++)
                    {
                        string c = b[j].ToString() ;
                        if(c == d)
                        {
                            Console.Write(slova[i] + ", ");
                            break;
                        }
                    }
                }
            }
            Console.WriteLine() ;
            Console.WriteLine("Введите слово, которое нужно найти:");
            string slovo = Console.ReadLine();
            for(int i = 0; i < slova.Length; i++)
            {
                if(slova[i] == slovo)
                {
                    Console.WriteLine($"Индекс первого вхождения слова {slovo}: {i}");
                    break;
                }
            }
        }
    }
}
