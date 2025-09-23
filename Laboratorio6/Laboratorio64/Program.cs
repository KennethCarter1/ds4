class Program
{
    static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Accesso negado - No cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("Accesso Concedido");
        }
    }

    static void Main(string[] args)
    {
        checkAge(15);
    }
}