using System;

class Program
{
    static void Main()
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
