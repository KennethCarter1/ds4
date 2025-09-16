using Laboratorio31;
using System;
internal class Program

{
    private static void Main(string[] args)
    {
        double Numero1, Numero2, Respuesta;

        CalculosMatematicos calc = new CalculosMatematicos();

        Console.Write("Introduce el primer numero:");
        Numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero:");
        Numero2 = Convert.ToInt32(Console.ReadLine());

        Respuesta = calc.Calcular(Numero1, Numero2);

        Console.WriteLine("La operacion de ({0}+{1})({0}-{1}) es : {2}", Numero1, Numero2, Respuesta);
    }


}