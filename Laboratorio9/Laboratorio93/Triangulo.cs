public class Triangulo
{
    public static bool ValidarTriangulo(double l1, double l2, double l3)
    {
        return (l1 + l2 > l3) && (l1 + l3 > l2) && (l2 + l3 > l1);
    }

    public static string TipoTriangulo(double l1, double l2, double l3)
    {
        if (l1 == l2 && l2 == l3)
            return "equilátero";
        else if (l1 == l2 || l1 == l3 || l2 == l3)
            return "isosceles";
        else
            return "escaleno";
    }
}