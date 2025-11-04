using System;
using Laboratorio31;


internal class Program
{
    private static void Main(string[] args)

    {
        double radio, respuesta;
        CalculosMatematicos calc = new CalculosMatematicos();

        Console.Write("Introduce el Radio del circulo:");
        radio = Convert.ToInt32(Console.ReadLine());

        respuesta = calc.calculoArea(radio);

        Console.WriteLine("El area del circulo es: {0}", respuesta);




        
    }
}