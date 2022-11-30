using System;

namespace Ex1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите длину окружности: ");
                    p = double.Parse(Console.ReadLine());

                    if (p <= 0) throw new Exception("Длина окружности не может быть меньше или равна нулю!");
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("Некорректное значение длины окружности! Попробуйте снова!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            double r = p / (2 * Math.PI);

            Console.Write($"Радиус окружности с длиной {p} равен: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Math.Round(r, 2)}");
            Console.ResetColor();
            Console.WriteLine(" (округлено до 2-х знаков после запятой)");
        }
    }
}
