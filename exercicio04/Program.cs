using System;

namespace exercicio04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double wage = 0;
            do
            {
                try
                {
                    Console.WriteLine("Seja bem-vindo ao calculo de reajuste salarial.\nMe diga qual o seu salário.\nLembrando quê:\nSSalários até R$ 2800,00 ajuste de 20%;\nSSalários entre R$ 2800,00 e R$ 7000,00: aumento de 15%;\nSalários entre R$ 7000,00 e R$ 15000,00: aumento de 10%;\nE salários acima de R$ 15000,00 almento de 5%.\nDigite seu salário.");
                    wage = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Um erro ocorreu.");
                    wage = -1;
                }
            } while (wage < 0);

            if (wage <= 2800.00)
            {
                double encrease = wage * 0.20;
                double finalwage = wage + encrease;
                Console.WriteLine("O seu almento é de 20%. Seu salário de R$ " + wage + "terá um acrécimo de R$ " + encrease + "E no fim seu salário será de " + finalwage);
            }
            else if (wage <= 7000.00)
            {
                double encrease = wage * 0.15;
                double finalwage = wage + encrease;
                Console.WriteLine("O seu almento é de 15%. Seu salário de R$ " + wage + "terá um acrécimo de R$ " + encrease + "E no fim seu salário será de " + finalwage);
            }
            else if (wage <= 15000.00)
            {
                double encrease = wage * 0.10;
                double finalwage = wage + encrease;
                Console.WriteLine("O seu almento é de 10%. Seu salário de R$ " + wage + "terá um acrécimo de R$ " + encrease + "E no fim seu salário será de " + finalwage);
            }
            else
            {
                double encrease = wage * 0.05;
                double finalwage = wage + encrease;
                Console.WriteLine("O seu almento é de 5%. Seu salário de R$ " + wage + "terá um acrécimo de R$ " + encrease + "E no fim seu salário será de " + finalwage);
            }
        }
    }
}