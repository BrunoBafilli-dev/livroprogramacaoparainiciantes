AplicarOperacao(5, 3, (a, b) => Console.WriteLine(a + b));
static void AplicarOperacao(int x, int y, Action<int, int> operacao)
{
    operacao(x, y);
}
