using System;

namespace exercicio09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá!\nVou verificar se a data que você digitar é válida.\nDigite no formato dd/mm/aaaa.\nPrimeiro, o dia: ");
            short dia = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Agora, o mês: ");
            short mes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Agora o ano: ");
            short ano = Convert.ToInt16(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                if (dia >= 1 && dia <= 31)
                {
                    Console.WriteLine($"A data inserida: {dia}/{mes}/{ano} é valida.");
                }
                else
                {
                    Console.Write($"A data inserida {dia}/{mes}/{ano} não é válida.");
                }
            }
            else if (mes == 2)
            {
                if (dia <= 1 && dia <= 29)
                {
                    Console.WriteLine($"A data inserida: {dia}/{mes}/{ano} é válida.");
                }
                else
                {
                    Console.WriteLine($"A data inserida: {dia}/{mes}/{ano} não é válida");
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                if (dia >= 1 && dia <= 30)
                {
                    Console.WriteLine($"A data inserida {dia}/{mes}/{ano} é válida.");
                }
                else
                {
                    Console.WriteLine($"A data inserida: {dia}/{mes}/{ano} não é válida.");
                }
            }
            else
            {
                Console.WriteLine($"A data inserida {dia}/{mes}/{ano} não é válida.");
            }
        }
    }
}