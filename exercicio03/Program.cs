using System;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Olá.\nVou te ajudar à escolher o melhor produto.\nInforme os valores de 3 produtos para que eu possa te ajudar à decidir.\nProduto 1: ");
        string? product01 = Console.ReadLine();
        Console.WriteLine("Produto 2: ");
        string? product02 = Console.ReadLine();
        Console.WriteLine("Produto 3: ");
        string? product03 = Console.ReadLine();

        double product1 = Convert.ToDouble(product01);
        double product2 = Convert.ToDouble(product02);
        double product3 = Convert.ToDouble(product03);

        if (product1 < product2 && product1 < product3)
        {
            Console.WriteLine("Escolha o produto 1.");
        }
        else if (product2 < product3)
        {
            Console.WriteLine("Escolha o produto 2.");
        }
        else
        {
            Console.WriteLine("Escolha o produto 3.");
        }
    }
}