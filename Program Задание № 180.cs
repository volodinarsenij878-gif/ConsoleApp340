using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program180
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Тип двигателя (1–Бензиновый, 2–Дизельный, 3–Гибридный, 4–Электрический): ");
            if (!int.TryParse(Console.ReadLine(), out int engine))
            {
                Console.WriteLine("Ошибка.");
                return;
            }

            string energy;
            switch (engine)
            {
                case 1: energy = "Бензин"; break;
                case 2: energy = "Дизельное топливо"; break;
                case 3: energy = "Бензин + электричество"; break;
                case 4: energy = "Электричество (аккумулятор)"; break;
                default:
                    Console.WriteLine("Неизвестный тип двигателя.");
                    return;
            }
            Console.WriteLine(energy);
        }
    }
}