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
            Console.WriteLine($"Sua nota 1 é: {nota1},\nSua nota 2 é: {nota2}\nA média entre elas foi de: {nota};\nO conseito foi A\nE você está aprovado.");
        }
        else if (nota >= 7.5 && nota <= 9.0)
        {
            Console.WriteLine($"Sua nota 1 é: {nota1}\nSua nota 2 é: {nota2}\nA média entre elas é: {nota}\nO conseito é B\nE você está aprovado;");
        }
        else if (nota >= 6.0 && nota <= 7.4)
        {
            Console.WriteLine($"Sua nota 1 é: {nota1}\nSua nota 2 é: {nota2}\nA média entre elas é: {nota}\nO conseito é C\nE você está aprovado;");
        }
        else if (nota >= 4.0 && nota <= 5.9)
        {
            Console.WriteLine($"Sua nota 1 é: {nota1}\nSua nota 2 é: {nota2}\nA média entre elas é: {nota}\nO conseito é D\nE você está Reprovado;");
        }
        else if (nota <= 3.9 && nota >= 0.0)
        {
            Console.WriteLine($"Sua nota 1 é: {nota1}\nSua nota 2 é: {nota2}\nA média entre elas é: {nota}\nO conseito é E\nE você está Reprovado;");
        }
        else
        {
            Console.WriteLine("Nota inválida!");
        }
    }
}