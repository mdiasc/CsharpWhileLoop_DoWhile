using System;

class Exemplo01
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o número a ser multilicado");
        int numero = Convert.ToInt32(Console.ReadLine());
        int contadora = 1;
        while (contadora<11)
        {
            Console.WriteLine(numero + "x" + contadora + " = " + numero*contadora);
            contadora++;
        }
    }
}