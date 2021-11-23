using System;

namespace Exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá!\nVou calcular sua nota, por favor, digite suas notas a seguir.\nDigite a nota 1: ");
            string? tN01 = Console.ReadLine();
            Console.WriteLine("Agora, digite a nota 2: ");
            string? tN2 = Console.ReadLine();
            double n01 = Convert.ToDouble(tN01);
            double n02 = Convert.ToDouble(tN2);
            double result = (n01 + n02) / 2;
            if (result == 10)
            {
                Console.WriteLine("Você se formou com distinção! Sua nota foi: " + result);
            }
            else if (result <= 7)
            {
                Console.WriteLine("Você não passou, sua nota foi: " + result);
            }
            else
            {
                Console.WriteLine("Você passou, sua nota foi: " + result);
            }
        }
    }
}