using System;

namespace Laboratorio31
{
    public class CalculosMatematicos
    {


        public CalculosMatematicos()
        {
        }

        public double Calcular(double a, double b)
        {
            double valor_1, valor_2, resultado;

            valor_1 = a + b;
            valor_2 = a - b;
            resultado = valor_1 * valor_2;

            return resultado;
        }

        public double calculoArea(double a)
        {
            double resultado;

            resultado = Math.PI * (Math.Pow(a, 2));
            return resultado;
        }

        public double perimetroRectangulo(double Base, double altura)
        {
            double resultado;
            resultado = 2 * (Base + altura);

            return resultado;

        }
    }
}
