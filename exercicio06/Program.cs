using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número de 1 a 7 para saber o dia da semana.");
        short number = Convert.ToInt16(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("Segunda-Feira");
                break;
            case 2:
                Console.WriteLine("terça-feira");
                break;
            case 3:
                Console.WriteLine("Quarta-feira");
                break;
            case 4:
                Console.WriteLine("Quinta-feira");
                break;
            case 5:
                Console.WriteLine("Sexta-feira");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("numero invalido, tente novamente");
                break;
        }
    }
}