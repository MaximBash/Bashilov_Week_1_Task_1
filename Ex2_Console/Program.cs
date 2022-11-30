using System;

namespace Ex2_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите трехзначное число: ");
                    number = int.Parse(Console.ReadLine());
                    number = Math.Abs(number);
                    
                    if (number.ToString().Length != 3) throw new Exception("Ожидается трехзначное число! Попробуйте снова!");
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("Некорректные число! Попробуйте снова!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            int first = number / 100;
            int second = number % 100;
            second %= 10;

            string result = (first > second) ? "Первая цифра числа больше последней" : (first == second) ? "Первая и последняя цифры совпадают" : "Последняя цифра числа больше первой";
            Console.WriteLine(result);
        }
    }
}
