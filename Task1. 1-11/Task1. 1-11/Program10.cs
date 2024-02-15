using System;

class Program10
{
    private static void Main(10)
    {
        Console.WriteLine("Таблица умножения:");

        // Вывод заголовка таблицы
        Console.Write("   ");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i,4}");
        }
        Console.WriteLine();

        // Вывод разделительной линии
        Console.WriteLine(new string('-', 41));

        // Вывод самой таблицы умножения
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i,2} |");
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }
}
