using System;

class Program6
{
    private static void Main(6)
    {
        Console.WriteLine("Введите число:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            CheckNumberEquality(number);
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
        }
    }

    static void CheckNumberEquality(int num)
    {
        if (num == 5 || num == 10)
        {
            Console.WriteLine("Число либо равно 5, либо равно 10.");
        }
        else
        {
            Console.WriteLine("Неизвестное число.");
        }
    }
}
