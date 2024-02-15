using System;

class Program4
{
    private static void Main(4)
    {
        Console.WriteLine("Введите первое число:");
        if (double.TryParse(Console.ReadLine(), out double number1))
        {
            Console.WriteLine("Введите второе число:");
            if (double.TryParse(Console.ReadLine(), out double number2))
            {
                CompareNumbers(number1, number2);
            }
            else
            {
                Console.WriteLine("Ошибка ввода второго числа. Пожалуйста, введите число.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода первого числа. Пожалуйста, введите число.");
        }
    }

    static void CompareNumbers(double num1, double num2)
    {
        if (num1 == num2)
        {
            Console.WriteLine("Введенные числа равны.");
        }
        else if (num1 > num2)
        {
            Console.WriteLine($"Первое число ({num1}) больше второго числа ({num2}).");
        }
        else
        {
            Console.WriteLine($"Первое число ({num1}) меньше второго числа ({num2}).");
        }
    }
}
