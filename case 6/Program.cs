using System;

namespace case_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину отрезка и единицу измерения:");
            Console.WriteLine("1 - десиметр, 2 - километр, 3 - миллиметр, 4 - сантиметр");

            string длина = Console.ReadLine();
            string ширина = Console.ReadLine();

            int длинаВЧисле = Int32.Parse(длина);
            int ширинаВЧисле = Int32.Parse(ширина);

            int метр = длинаВЧисле;

            switch (ширинаВЧисле)
            {
                case 1: 
                    метр = длинаВЧисле / 10; 
                    break;

                case 2: 
                    метр = длинаВЧисле * 1000; 
                    break;

                case 3: 
                    метр = длинаВЧисле / 1000; 
                    break;

                case 4: 
                    метр = длинаВЧисле / 100; 
                    break;

                default:
                    Console.WriteLine("Неизвестная единица измерения.");
                    return; 
            }

            Console.WriteLine($"Длина отрезка в метрах: {метр} м");
        }
    }
}