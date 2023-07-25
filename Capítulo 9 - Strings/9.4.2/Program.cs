string texto1 = "Olá";
string texto2 = "olá";
bool saoIguais = texto1.Equals(texto2, StringComparison.CurrentCultureIgnoreCase);
Console.WriteLine(saoIguais);
