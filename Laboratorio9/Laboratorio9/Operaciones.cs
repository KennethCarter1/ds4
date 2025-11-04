public static class Operaciones
{
    public static bool ValidarPrecio(string entrada)
    {
        double valor;
        return double.TryParse(entrada, out valor) && valor > 0;
    }

    public static bool ValidarPago(string pago)
    {
        pago = pago.ToLower();
        return pago == "efectivo" || pago == "tarjeta";
    }

    public static bool ValidarCuenta(string numCuenta)
    {
        return numCuenta.Length == 16 && long.TryParse(numCuenta, out _);
    }
}
