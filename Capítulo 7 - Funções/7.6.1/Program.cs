int numero = 5;
int resultado = CalcularFatorial(numero);
Console.WriteLine($"O fatorial de {numero} é {resultado}.");

static int CalcularFatorial(int n)
{
    if (n == 0 || n == 1)
        return 1;
    return n * CalcularFatorial(n - 1);
}
