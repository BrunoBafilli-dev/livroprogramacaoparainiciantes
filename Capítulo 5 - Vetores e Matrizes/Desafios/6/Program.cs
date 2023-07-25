// Solicitar ao usuário o tamanho do vetor
Console.Write("Digite o tamanho do vetor: ");
int tamanho = int.Parse(Console.ReadLine());
// Lê o tamanho do vetor fornecido pelo usuário e armazena na variável "tamanho".

// Criar o vetor com o tamanho informado pelo usuário
int[] vetor = new int[tamanho];
// Cria um vetor de inteiros chamado "vetor" com o tamanho informado pelo usuário.

// Preencher o vetor com os valores informados pelo usuário
for (int i = 0; i < tamanho; i++)
{
    Console.Write($"Digite o valor para o elemento {i + 1}: ");
    vetor[i] = int.Parse(Console.ReadLine());
    // Pede ao usuário para fornecer um valor para cada elemento do vetor.
    // Os valores fornecidos são armazenados nos elementos correspondentes do vetor.
}

// Ordenar o vetor por inserção
for (int i = 1; i < tamanho; i++)
{
    int chave = vetor[i];
    int j = i - 1;

    // Move os elementos maiores do que a chave para a direita
    while (j >= 0 && vetor[j] > chave)
    {
        vetor[j + 1] = vetor[j];
        j--;
    }

    // Coloca a chave em sua posição correta
    vetor[j + 1] = chave;
    // Coloca o valor da chave (vetor[i]) na posição correta para que o vetor fique ordenado.
}

// Exibir o vetor ordenado
Console.WriteLine("\nVetor ordenado:");
for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine($"Elemento {i + 1}: {vetor[i]}");
    // Exibe o vetor ordenado na tela, elemento por elemento, com a numeração dos elementos começando em 1.
}
        