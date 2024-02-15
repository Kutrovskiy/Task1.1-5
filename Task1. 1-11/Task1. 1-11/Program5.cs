using System;

class Program5
{
    private static void Main(5)
    {
        Console.WriteLine("Введите число:");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            CheckNumberRange(number);
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
        }
    }

    static void CheckNumberRange(double num)
    {
        if (num >= 5 && num <= 10)
        {
            Console.WriteLine("Число больше 5 и меньше 10.");
        }
        else
        {
            Console.WriteLine("Неизвестное число.");
        }
    }
}
