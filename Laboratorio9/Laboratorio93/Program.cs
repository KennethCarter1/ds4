using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Clasificador de Triángulos ===");

        Console.Write("Ingresa el primer lado: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo lado: ");
        double lado2 = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el tercer lado: ");
        double lado3 = double.Parse(Console.ReadLine());

        if (Triangulo.ValidarTriangulo(lado1, lado2, lado3))
        {
            string tipo = Triangulo.TipoTriangulo(lado1, lado2, lado3);
            Console.WriteLine($"El triángulo es {tipo}.");
        }
        else
        {
            Console.WriteLine("No se puede formar un triángulo con esos lados.");
        }
    }
}