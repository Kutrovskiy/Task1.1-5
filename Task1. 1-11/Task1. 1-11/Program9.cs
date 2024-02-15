using System;

class Program9
{
    private static void Main(9)
    {
        Console.WriteLine("Введите сумму вклада:");
        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
        {
            Console.WriteLine("Введите количество месяцев:");
            if (int.TryParse(Console.ReadLine(), out int numberOfMonths) && numberOfMonths > 0)
            {
                CalculateFinalAmount(depositAmount, numberOfMonths);
            }
            else
            {
                Console.WriteLine("Ошибка ввода количества месяцев. Пожалуйста, введите положительное целое число.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода суммы вклада. Пожалуйста, введите положительное число.");
        }
    }

    static void CalculateFinalAmount(decimal principal, int months)
    {
        const decimal interestRate = 0.07m; // 7%

        for (int i = 1; i <= months; i++)
        {
            principal += principal * interestRate;
        }

        Console.WriteLine($"Конечная сумма вклада после {months} месяцев: {principal:C}");
    }
}
