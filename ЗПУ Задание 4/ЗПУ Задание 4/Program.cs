using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        if (double.TryParse(Console.ReadLine(), out double depositAmount))
        {
            double interestRate;

            if (depositAmount < 100)
            {
                interestRate = 0.05; // 5%
            }
            else if (depositAmount >= 100 && depositAmount <= 200)
            {
                interestRate = 0.07; // 7%
            }
            else
            {
                interestRate = 0.1; // 10%
            }

            double totalAmount = CalculateTotalAmount(depositAmount, interestRate);

            Console.WriteLine($"Сумма вклада с начисленными процентами: {totalAmount:C}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректную сумму вклада.");
        }
    }

    static double CalculateTotalAmount(double principal, double rate)
    {
        return principal * (1 + rate);
    }
}
