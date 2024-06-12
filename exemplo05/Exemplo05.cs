using System;

class Exemplo05 {
    public static void Main(string[]args) 
    {
        int contadora = 15;
        do 
        {
            Console.WriteLine("O quadrado de " + contadora + "é: " + contadora * contadora);
            contadora++;
        }
        while (contadora < 201);
    }
}