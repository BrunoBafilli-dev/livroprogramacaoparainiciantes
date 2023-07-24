// Solicitar ao usuário que insira o número inicial da contagem regressiva
Console.Write("Digite um número para iniciar a contagem regressiva: ");

// Ler o número digitado pelo usuário e armazená-lo em uma variável
int numeroInicial = int.Parse(Console.ReadLine());

// Realizar a contagem regressiva utilizando o loop for
for (int i = numeroInicial; i >= 0; i--)
{
    // Exibir o número atual da contagem
    Console.WriteLine(i);
}