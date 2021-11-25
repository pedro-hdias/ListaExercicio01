using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite os valores dos 3 lados do triângulo e veremos se é triângulo e qual o tipo.\nDigite o lado 1: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Agora, o lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o terceiro lado: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());
        if ((lado1 + lado2 > lado3) && (lado2 + lado3) > lado1 && (lado1 + lado3) > lado2)
        {
            Console.WriteLine("Os valores que me informou são de triângulo. O tipo dele é: ");
            if (lado1 == lado2 && lado2 == lado3 && lado1 == lado3)
            {
                Console.WriteLine("Equilátero.");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("Isósceles.");
            }
            else
            {
                Console.WriteLine("Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Não é Triângulo.");
        }
    }
}