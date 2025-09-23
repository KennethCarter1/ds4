class PruebaVector1
{
    private int[] sueldos; // Declaramos un vector

    public void Cargar()
    {
        sueldos = new int[5]; 
        for (int f = 0; f < 5; f++)
        {
            Console.Write("Ingrese sueldo del operario " + (f + 1) + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); 
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los operarios:\n");
        for (int f = 0; f < 5; f++)
        {
            Console.Write("[" + sueldos[f] + "] ");
        }
        Console.ReadKey();
    }
}

class Program
{
    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();
    }
}
