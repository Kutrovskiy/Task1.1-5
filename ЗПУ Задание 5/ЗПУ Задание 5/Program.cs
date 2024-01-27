using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");

        if (int.TryParse(Console.ReadLine(), out int operationNumber))
        {
            switch (operationNumber)
            {
                case 1:
                    Console.WriteLine("Вы выбрали операцию: Сложение");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали операцию: Вычитание");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали операцию: Умножение");
                    break;
                default:
                    Console.WriteLine("Операция неопределена.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректный номер операции.");
        }
    }
}
