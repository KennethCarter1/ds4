using Laboratorio31;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double Base, altura, resultado;
        CalculosMatematicos calc = new CalculosMatematicos();

        Console.Write("Introduce el primer numero:");
        Base = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero:");
        altura = Convert.ToInt32(Console.ReadLine());

        resultado = calc.perimetroRectangulo(Base, altura);

        Console.WriteLine("El perimetro es: {0}", resultado);


    }
}