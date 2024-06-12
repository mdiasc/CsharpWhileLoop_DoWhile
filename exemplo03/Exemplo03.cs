using System;

class Exemplo01
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o número a ser multilicado");
        int contadora = 0, acumuladora = 0;
        while (contadora<101)
        {
            acumuladora += contadora;
            contadora++;
            Console.WriteLine()
        }
    }
}