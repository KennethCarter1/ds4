Dictionary<string, string> paisesYCapital = new Dictionary<string, string>
{
    { "Francia", "París" },
    { "España", "Madrid" },
    {"Italia", "Roma" }

};

foreach (KeyValuePair<string, string> par in paisesYCapital)
{
    Console.WriteLine("La capital de " + par.Key + " es " + par.Value + ".");
}