// Criando uma função anônima que soma dois números inteiros.
Func<int, int, int> somar = delegate(int x, int y)
{
    return x + y;
};

// Chamando a função anônima para somar dois números (por exemplo, 5 e 10).
int resultado = somar(5, 10);

// Exibindo o resultado na tela.
Console.WriteLine("A soma dos dois números é: " + resultado);