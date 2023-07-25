int numero = 5;
Console.WriteLine("Valor original: " + numero);
IncrementarPorReferencia(ref numero);
Console.WriteLine("Valor após a função IncrementarPorReferencia: " + numero);

static void IncrementarPorReferencia(ref int valor)
{
    valor++;
}
