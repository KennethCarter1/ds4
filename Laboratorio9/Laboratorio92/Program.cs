using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Numeros del 1 al 100 que son pares o divisibles entre 3:");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0 || i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}