using System;

public class Program
{
    public static void Main(string[] args)
    {
        double inss = 0.10;
        double fgts = 0.11;
        Console.WriteLine("Olá, vou calcular os dados de seu salário.\nVamos lá, você deve digitar o número de horas trabalhadas e quanto vale a hora trabalhada. Digite o valor da hora trabalhada: ");
        string? valueHour = Console.ReadLine();
        double valueHours = Convert.ToDouble(valueHour);
        Console.WriteLine("Agora, quantas horas você trabalhou este mês?");
        string? workedHour = Console.ReadLine();
        double workedHours = Convert.ToDouble(workedHour);

        double total = valueHours * workedHours;
        if (total < 2000.00)
        {
            double wage1 = total * inss;
            double wage2 = total * fgts;
            double wageLiquid = total - wage1;
            Console.WriteLine("Este mez, seu salário, SEM DESCONTOS,  será de: R$" + total + "\nO  o desconto de 10% do INSS totaliza: -R$" + wage1 + ".\nA empresa depositará: R$" + wage2 + "de FGTS.\nSeu salário líquido total será de: R$" + wageLiquid);
        }
        if (total <= 5000.00)
        {
            double wage1 = total * inss;
            double wage2 = total * fgts;
            double wage3 = total * 0.05;
            double wageLiquid = total - wage1 - wage3;
            Console.WriteLine("Este mez, seu salário, SEM DESCONTOS,  será de: R$" + total + "\nO  o desconto de 10% do INSS totaliza: -R$" + wage1 + ".\nA empresa depositará: R$" + wage2 + "de FGTS.\nO desconto de IR de 5% representa R$-" + wage3 + ";\nSeu salário líquido total será de: R$" + wageLiquid);
        }
        else if (total < 7500.00)
        {
            double wage1 = total * inss;
            double wage2 = total * fgts;
            double wage3 = total * 0.10;
            double wageLiquid = total - wage1 - wage3;
            Console.WriteLine("Este mez, seu salário, SEM DESCONTOS,  será de: R$" + total + "\nO  o desconto de 10% do INSS totaliza: -R$" + wage1 + ".\nA empresa depositará: R$" + wage2 + "de FGTS.\nO desconto de IR de 10% representa R$-" + wage3 + ";\nSeu salário líquido total será de: R$" + wageLiquid);
        }
        else
        {
            double wage1 = total * inss;
            double wage2 = total * fgts;
            double wage3 = total * 0.20;
            double wageLiquid = total - wage1 - wage3;
            Console.WriteLine("Este mez, seu salário, SEM DESCONTOS,  será de: R$" + total + "\nO  o desconto de 10% do INSS totaliza: -R$" + wage1 + ".\nA empresa depositará: R$" + wage2 + "de FGTS.\nO desconto de IR de 20% representa R$-" + wage3 + ";\nSeu salário líquido total será de: R$" + wageLiquid);
        }
    }
}