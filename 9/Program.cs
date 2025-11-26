using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[]
            {
                "Иванова София,5,5,4,5",
                "Катичев Михаил,3,4,5,4",
                "Кошкин Степан,5,3,5,4",
                "Петрова Александра,5,5,5,5",
                "Зайцев Василий,3,3,3,2",
                "Лялькина Анастасия,5,2,4,5",
                "Фиалкин Алексей,4,5,3,4",
                "Галкина Варвара,4,5,3,5",
                "Орлов Павел,3,2,2,2",
                "Семенов Михаил,4,5,3,4",
            };
            string[] subjects = new string[] {"Русский язык", "Математика", "История", "Химия"};
            Console.WriteLine($"Учет студентов по таким предметам,как:");
            foreach(var i in subjects)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
            foreach(var i in students)
            {
                string[] parts = i.Split(',');
                Console.WriteLine($"  - {parts[0]}: {parts[1]}, {parts[2]}, {parts[3]}, {parts[4]}.");
            }
            Console.WriteLine("Введите минимальный средний балл для поиска:");
            double a = Convert.ToDouble( Console.ReadLine());
         
            Console.WriteLine($"Студенты со средним баллом выше {a}:");
            foreach(string i in students)
            {
                string[] parts = i.Split(',');
                string name = parts[0];
                double sum = 0;
                for(int j = 1; j < parts.Length; j++) 
                {
                    sum += Convert.ToDouble(parts[j]);
                }
                double aver = sum / (parts.Length - 1);
                if(aver > a)
                {
                    Console.WriteLine($"  - {name}, средний балл: {aver:F2}");
                }
            }

            Console.WriteLine("Средние баллы по предметам:");
            double[] subaver = new double[subjects.Length];
            for (int subindex = 0; subindex < subjects.Length; subindex++)
            {
                double subsum = 0;
                foreach (string s in students)
                {
                    string[] part = s.Split(',');
                    subsum += Convert.ToInt32(part[subindex + 1]);
                }
                subaver[subindex] = subsum / students.Length;
                Console.WriteLine($"  - {subjects[subindex]} средний балл: {subaver[subindex]:F1}");
            }
            double maxsub = 0;
            string bestsub = "";
            for(int i = 0; i < subaver.Length; i++)
            {
                if(subaver[i] > maxsub)
                {
                    maxsub = subaver[i];    
                    bestsub = subjects[i];
                }
            }
            Console.WriteLine($"Предмет с наивысшим средним баллом: {bestsub} ({maxsub:F1})");
            Console.WriteLine("Рейтинг студентов по успеваемости:");
            string excellent = "Отличники (средний балл > 4.5): ";
            string poor = "Двоечники (средний балл < 3.0): ";
            int hasExcellent = 0;
            int hasPoor = 0;
            string[] rating = new string[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                string[] parts = students[i].Split(',');
                string name = parts[0];
                double sum = 0;
                for (int j = 1; j < parts.Length; j++)
                {
                    sum += Convert.ToDouble(parts[j]);
                }
                double average = sum / (parts.Length - 1);
                if (average >= 4.5)
                {
                    excellent += name + ", ";
                    hasExcellent++;
                }
                else if (average < 3.0)
                {
                    poor += name + ", ";
                    hasPoor++;
                }
                rating[i] = $"{name}-{average}";
            }
            var sr = rating.OrderBy(b => Convert.ToDouble(b.Split('-')[1]));
            foreach(string s in sr)
            {
                Console.WriteLine($"  - {s.Split('-')[0]} со средним баллом {s.Split('-')[1]:F2}");
            }
            Console.WriteLine("Категории студентов:");
            if (hasExcellent > 0)
                Console.WriteLine(excellent.TrimEnd(',', ' '));
            else
                Console.WriteLine("Отличников нет");

            if (hasPoor > 0)
                Console.WriteLine(poor.TrimEnd(',', ' '));
            else
                Console.WriteLine("Двоечников нет");
        }
    }
}
    

