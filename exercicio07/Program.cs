using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite sua nota e  veremos qual é o conseito da sua nota.\nNota 1:");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nota 2");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        double nota = (nota1 + nota2) / 2;

        if (nota >= 9.1 && nota <= 10.0)
        {
            Console.WriteLine("Conseito A");
        }
        else if (nota >= 7.5 && nota <= 9.0)
        {
            Console.WriteLine("Conseito B");
        }
        else if (nota >= 6.0 && nota <= 7.4)
        {
            Console.WriteLine("Conseito C");
        }
        else if (nota >= 4.0 && nota <= 5.9)
        {
            Console.WriteLine("Conseito D");
        }
        else if (nota <= 3.9 && nota >= 0.0)
        {
            Console.WriteLine("Conseito E");
        }
        else
        {
            Console.WriteLine("Nota inválida!");
        }
    }
}