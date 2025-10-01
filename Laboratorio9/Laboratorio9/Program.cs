using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sistema de Pago ===");

        
        double precio = 0;
        bool valido = false;
        while (!valido)
        {
            Console.WriteLine("Ingresa el precio del producto (valor positivo):");
            string input = Console.ReadLine();
            if (Operaciones.ValidarPrecio(input))
            {
                precio = Convert.ToDouble(input);
                valido = true;
            }
            else
            {
                Console.WriteLine("Precio invalido. Intenta de nuevo.");
            }
        }

       
        string pago = "";
        while (true)
        {
            Console.WriteLine("Ingresa la forma de pago (efectivo o tarjeta):");
            pago = Console.ReadLine();
            if (Operaciones.ValidarPago(pago))
                break;
            else
                Console.WriteLine("Pago inválido. Intenta de nuevo.");
        }

       
        string numCuenta = null;
        if (pago.ToLower() == "tarjeta")
        {
            while (true)
            {
                Console.WriteLine("Ingresa el número de cuenta (16 dígitos):");
                numCuenta = Console.ReadLine();
                if (Operaciones.ValidarCuenta(numCuenta))
                    break;
                else
                    Console.WriteLine("Número de cuenta inválido. Intenta de nuevo.");
            }
        }

       
        Console.WriteLine("\n--- Resumen ---");
        Console.WriteLine($"Precio: {precio}");
        Console.WriteLine($"Forma de pago: {pago}");
        if (numCuenta != null)
            Console.WriteLine($"Número de cuenta: {numCuenta}");
    }
}

