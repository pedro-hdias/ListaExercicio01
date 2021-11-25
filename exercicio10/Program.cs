using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Me diga um número e eu vou dizer se é par ou ímpar.");
        long number = Convert.ToInt64(Console.ReadLine());
        long result = number % 2;
        if (result == 0)
        {
            Console.WriteLine($"O número {number} é par.");
        }
        else
        {
            Console.WriteLine($"O número {number} é ímpar.");
        }
    }
}