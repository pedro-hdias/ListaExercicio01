using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Seja bem-vindo ao calculo de reajuste salarial.\nMe diga qual o seu salário.\nLembrando quê:\nSSalários até R$ 2800,00 ajuste de 20%;\nSSalários entre R$ 2800,00 e R$ 7000,00: aumento de 15%;\nSalários entre R$ 7000,00 e R$ 15000,00: aumento de 10%;\nE salários acima de R$ 15000,00 almento de 5%.\nDigite seu salário.");
        string? wage = Console.ReadLine();
        double Wage = Convert.ToDouble(wage);

        if (Wage <= 2800.00)
        {
            double encrease = Wage * 0.20;
            double finalWage = Wage + encrease;
            Console.WriteLine("O seu almento é de 20%. Seu salário de R$ " + Wage + "terá um acrécimo de R$ " + encrease + "E no fim seu salário será de " + finalWage);
        }
        else if (Wage <= 7000.00)
        {
            double encrease = Wage * 0.15;
            double finalWage = Wage + encrease;
            Console.WriteLine("O seu almento é de 15%. Seu salário de R$ " + Wage + "terá um acrécimo de R$ " + encrease + "E no fim seu salário será de " + finalWage);
        }
        else if (Wage <= 15000.00)
        {
            double encrease = Wage * 0.10;
            double finalWage = Wage + encrease;
            Console.WriteLine("O seu almento é de 10%. Seu salário de R$ " + Wage + "terá um acrécimo de R$ " + encrease + "E no fim seu salário será de " + finalWage);
        }
        else
        {
            double encrease = Wage * 0.05;
            double finalWage = Wage + encrease;
            Console.WriteLine("O seu almento é de 5%. Seu salário de R$ " + Wage + "terá um acrécimo de R$ " + encrease + "E no fim seu salário será de " + finalWage);
        }
    }
}