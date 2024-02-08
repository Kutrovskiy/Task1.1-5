using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите два числа (от 0 до 10):");

            double number1, number2;

            // Ввод первого числа
            while (true)
            {
                Console.Write("Первое число: ");
                if (double.TryParse(Console.ReadLine(), out number1) && number1 >= 0 && number1 <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Недопустимое число. Пожалуйста, введите число от 0 до 10.");
                }
            }

            // Ввод второго числа
            while (true)
            {
                Console.Write("Второе число: ");
                if (double.TryParse(Console.ReadLine(), out number2) && number2 >= 0 && number2 <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Недопустимое число. Пожалуйста, введите число от 0 до 10.");
                }
            }

            // Вывод произведения и выход из бесконечного цикла
            double result = number1 * number2;
            Console.WriteLine($"Произведение чисел {number1} и {number2} равно {result}");
            break;
        }
    }
}
