using System;

class Program
{
    static void Main()
    {
        Aleatorios aleatorio = new Aleatorios();

        int min = 1;
        int max = 20;
        int cantidad = 10;

        if (cantidad > (max - min + 1))
        {
            Console.WriteLine("No se puede generar esa cantidad de números únicos en el rango indicado.");
            return;
        }

        int[] numerosUnicos = new int[cantidad];
        int index = 0;

        while (index < cantidad)
        {
            int num = aleatorio.GenerarNumero(min, max);
            bool repetido = false;

            
            for (int i = 0; i < index; i++)
            {
                if (numerosUnicos[i] == num)
                {
                    repetido = true;
                    break;
                }
            }

            if (!repetido)
            {
                numerosUnicos[index] = num;
                index++;
            }
        }

        Console.WriteLine("Arreglo de números no repetidos:");
        for (int i = 0; i < numerosUnicos.Length; i++)
        {
            Console.Write(numerosUnicos[i] + " ");
        }
        Console.WriteLine();
    }
}
