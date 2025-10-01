using System;

class Program
{
    static void Main()
    {
        Aleatorios aleatorio = new Aleatorios();

        
        int numero = aleatorio.GenerarNumero(1, 10);
        Console.WriteLine("Número aleatorio entre 1 y 10: " + numero);

        
        int[] arreglo = aleatorio.GenerarArreglo(5, 50, 100);
        Console.WriteLine("Arreglo de 5 números aleatorios entre 50 y 100:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write(arreglo[i] + " ");
        }
        Console.WriteLine();
    }
}
