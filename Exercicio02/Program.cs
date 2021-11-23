using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá!\nDigite 3 números e eu vou lhe mostrar o maior e  o menor.\nDigite o primeiro número: ");
            string? tN1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo número: ");
            string? tN2 = Console.ReadLine();
            Console.WriteLine("Digite o terceiro número: ");
            string? tN3 = Console.ReadLine();
            int n1 = Convert.ToInt32(tN1);
            int n2 = Convert.ToInt32(tN2);
            int n3 = Convert.ToInt32(tN3);
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine(n2);
            }
            else
            {
                Console.WriteLine(n3);
            }
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine(n1);
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine(n2);
            }
            else
            {
                Console.WriteLine(n3);
            }
        }
    }
}